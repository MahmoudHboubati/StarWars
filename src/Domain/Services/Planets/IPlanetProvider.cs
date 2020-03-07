using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services.Planets
{
    public interface IPlanetProvider
    {
        Task<IEnumerable<PlanetLargestPilot>> GetLargestVehiclePilot();
    }
}
