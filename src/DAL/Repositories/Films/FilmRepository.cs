using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories.Films;
using Infrastructure;

namespace DAL.Repositories.Films
{
    public class FilmRepository : IFilmRepository
    {
        private readonly StarWarsDbContext context;

        public FilmRepository(StarWarsDbContext starWarDbContext)
        {
            this.context = starWarDbContext;
        }

        public IEnumerable<Film> Get()
        {
            return context.Films.ToList();
        }
    }
}
