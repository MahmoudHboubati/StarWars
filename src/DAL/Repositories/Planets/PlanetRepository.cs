using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Constants;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories.Planets;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Planets
{
    public class PlanetRepository : BaseRepository<PlanetLargestPilot>, IPlanetRepository
    {
        public PlanetRepository(StarWarsDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PlanetLargestPilot>> GetLargestVehiclePilot()
        {
            var query = SqlQueries.MOST_VEHICLE_PILOTS_IN_SPECIES;
            var mostVehiclePilots = await context.PlanetLargestPilots.FromSqlRaw<PlanetLargestPilot>(query).ToListAsync();

            return mostVehiclePilots;
        }
    }
}
