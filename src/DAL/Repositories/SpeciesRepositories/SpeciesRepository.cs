using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Repositories.Base;
using Domain.Entities.KeyLessEntities.SpeciesEntities;
using Domain.Entities.SpeciesEntities;
using Domain.Repositories.SpeciesRepositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using DAL.Constants;

namespace DAL.Repositories.SpeciesRepositories
{
    public class SpeciesRepository : BaseRepository<Species>, ISpeciesRepository
    {
        public SpeciesRepository(StarWarsDbContext context) : base(context) { }

        public async Task<IEnumerable<SpeciesAggregate>> GetMostAppeared()
        {
            var query = SqlQueries.MOST_APPEARED_SPECIES;
            return await context.SpeciesAggregate.FromSqlRaw<SpeciesAggregate>(query).ToListAsync();
        }
    }
}
