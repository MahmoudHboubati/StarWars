using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.SpeciesEntities;

namespace Domain.Repositories.SpeciesRepositories
{
    public interface ISpeciesRepository
    {
        Task<IEnumerable<SpeciesAggregate>> GetMostAppeared();
    }
}
