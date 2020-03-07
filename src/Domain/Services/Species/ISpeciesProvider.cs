using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.KeyLessEntities.SpeciesEntities;

namespace Domain.Services.Species
{
    public interface ISpeciesProvider
    {
        Task<IEnumerable<SpeciesAggregate>> GetMostAppeared();
    }
}
