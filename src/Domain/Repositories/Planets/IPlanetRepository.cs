using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories.Planets
{
    public interface IPlanetRepository
    {
        Task<IEnumerable<PlanetLargestPilot>> GetLargestVehiclePilot();
    }
}