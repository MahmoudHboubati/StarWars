using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Services.Films;
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

        [HttpGet("getMostPersonAppeared")]
        public IActionResult GetMostPersonAppeared()
        {
            return Ok(provider.GetMostPersonAppeared());
        }
    }
}
