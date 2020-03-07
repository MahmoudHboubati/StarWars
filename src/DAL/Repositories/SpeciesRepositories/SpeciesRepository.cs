using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Constants;
using DAL.Repositories.Base;
using Domain.Entities.KeyLessEntities.SpeciesEntities;
using Domain.Entities.SpeciesEntities;
using Domain.Repositories.SpeciesRepositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.SpeciesRepositories
{
    public class SpeciesRepository : BaseRepository<Species>, ISpeciesRepository
    {
        public SpeciesRepository(StarWarsDbContext context) : base(context) { }

        public async Task<IEnumerable<SpeciesAggregate>> GetMostAppeared()
        {
            //use raw queries since groupBy (client) is not allowed in core 3.1
            var query = SqlQueries.MOST_APPEARED_SPECIES;
            var mostAppearedInSpecies = await context.SpeciesAggregate.FromSqlRaw<SpeciesAggregate>(query).ToListAsync();
            var filmsCount = await context.Films.CountAsync();

            //assuming not all counts, only who appeared in most of films (most >= half)
            var mostOfFilmsCount = filmsCount / 2;

            return mostAppearedInSpecies.Where(a => a.Count >= mostOfFilmsCount);
        }
    }
}
