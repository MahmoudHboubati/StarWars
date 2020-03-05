using System.Threading.Tasks;
using Api.resources;
using AutoMapper;
using Domain.Services.Peoples;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleProvider provider;
        private readonly IMapper mapper;

        public PeopleController(IPeopleProvider provider, IMapper mapper)
        {
            this.mapper = mapper;
            this.provider = provider;
        }

        [HttpGet("getMostAppeared")]
        public async Task<ActionResult<PeopleDto>> GetMostAppeared()
        {
            var result = await provider.GetMostAppeared();
            return Ok(mapper.Map<PeopleDto>(result));
        }
    }
}
