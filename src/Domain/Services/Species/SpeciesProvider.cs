using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.SpeciesEntities;
using Domain.Repositories.SpeciesRepositories;

namespace Domain.Services.Species
{
    public class SpeciesProvider : ISpeciesProvider
    {
        readonly ISpeciesRepository repository;

        public SpeciesProvider(ISpeciesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<SpeciesAggregate>> GetMostAppeared()
        {
            return await repository.GetMostAppeared();
        }
    }
}
