using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Repositories.Films;

namespace Domain.Services.Films
{
    public class FilmProvider : IFilmProvider
    {
        private readonly IFilmRepository repository;

        public FilmProvider(IFilmRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Film> Get()
        {
            return repository.Get();
        }
    }
}
