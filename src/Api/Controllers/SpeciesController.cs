using System.Collections.Generic;
using System.Threading.Tasks;
using Api.resources;
using AutoMapper;
using Domain.Services.Species;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeciesController : ControllerBase
    {
        readonly ISpeciesProvider provider;
        readonly IMapper mapper;

        public SpeciesController(ISpeciesProvider provider, IMapper mapper)
        {
            this.provider = provider;
            this.mapper = mapper;
        }

        [HttpGet("getMostAppeared")]
        public async Task<ActionResult<IEnumerable<SpeciesAggregateDto>>> GetMostAppeared()
        {
            var result = await provider.GetMostAppeared();
            return Ok(mapper.Map<IEnumerable<SpeciesAggregateDto>>(result));
        }
    }
}
