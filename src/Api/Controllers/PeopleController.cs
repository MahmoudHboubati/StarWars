using Domain.Services.Peoples;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleProvider provider;

        public PeopleController(IPeopleProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet("getMostAppeared")]
        public IActionResult GetMostAppeared()
        {
            return Ok(provider.GetMostAppeared());
        }
    }
}
