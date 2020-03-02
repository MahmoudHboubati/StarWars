using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories.Films;
using Infrastructure;

namespace DAL.Repositories.Films
{
    public class FilmRepository : BaseRepository, IFilmRepository
    {
        public FilmRepository(StarWarsDbContext context) : base(context)
        {
        }

        public IEnumerable<Film> Get()
        {
            return context.Films.ToList();
        }
    }
}
