using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.KeyLessEntities.SpeciesEntities;

namespace Domain.Repositories.SpeciesRepositories
{
    public interface ISpeciesRepository
    {
        Task<IEnumerable<SpeciesAggregate>> GetMostAppeared();
    }
}
