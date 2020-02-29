using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Services.Films;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmProvider provider;

        public FilmController(IFilmProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(provider.Get());
        }
    }
}
