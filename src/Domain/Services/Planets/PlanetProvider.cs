using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories.Planets;

namespace Domain.Services.Planets
{
    public class PlanetProvider : IPlanetProvider
    {
        readonly IPlanetRepository repository;

        public PlanetProvider(IPlanetRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<PlanetLargestPilot>> GetLargestVehiclePilot()
        {
            return repository.GetLargestVehiclePilot();
        }
    }
}
