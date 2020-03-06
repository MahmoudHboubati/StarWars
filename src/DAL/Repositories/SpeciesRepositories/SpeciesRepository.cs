using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Repositories.Base;
using Infrastructure;
using Domain.Entities.SpeciesEntities;
using Domain.Repositories.SpeciesRepositories;

namespace DAL.Repositories.SpeciesRepositories
{
    public class SpeciesRepository : BaseRepository<Species>, ISpeciesRepository
    {
        readonly StarWarsDbContext context;

        public SpeciesRepository(StarWarsDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<SpeciesAggregate>> GetMostAppeared()
        {
            throw new System.NotImplementedException();
        }
    }
}
