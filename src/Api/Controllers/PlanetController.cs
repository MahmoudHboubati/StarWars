using System.Collections.Generic;
using System.Threading.Tasks;
using Api.resources;
using AutoMapper;
using Domain.Services.Planets;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetController : ControllerBase
    {
        readonly IPlanetProvider provider;
        readonly IMapper mapper;

        public PlanetController(IPlanetProvider provider, IMapper mapper)
        {
            this.provider = provider;
            this.mapper = mapper;
        }

        [HttpGet("getLargestVehiclePilot")]
        public async Task<ActionResult<IEnumerable<PlanetLargestPilotDto>>> GetLargestVehiclePilot()
        {
            var result = await provider.GetLargestVehiclePilot();
            return Ok(mapper.Map<IEnumerable<PlanetLargestPilotDto>>(result));
        }
    }
}
