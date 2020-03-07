using System.Threading.Tasks;
using Api.resources;
using AutoMapper;
using Domain.Services.Films;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        readonly IFilmProvider provider;
        readonly IMapper mapper;

        public FilmController(IFilmProvider provider, IMapper mapper)
        {
            this.provider = provider;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(provider.Get());
        }
        
        [HttpGet("getLongestOpeningCrawl")]
        public async Task<ActionResult<LongestOpeningCrawlDto>> GetLongestOpeningCrawl()
        {
            var result = await provider.GetLongestOpeningCrawl();
            return Ok(mapper.Map<LongestOpeningCrawlDto>(result));
        }
    }
}
