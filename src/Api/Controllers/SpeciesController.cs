using System.Threading.Tasks;
using Api.resources;
using AutoMapper;
using Domain.Services.Species;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class SpeciesController : ControllerBase
    {
        readonly ISpeciesProvider provider;
        readonly IMapper mapper;

        public SpeciesController(ISpeciesProvider provider, IMapper mapper)
        {
            this.provider = provider;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<SpeciesAggregateDto>> GetMostAppeared()
        {
            var result = await provider.GetMostAppeared();
            return Ok(mapper.Map<SpeciesAggregateDto>(result));
        }
    }
}
