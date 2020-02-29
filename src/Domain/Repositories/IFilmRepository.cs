using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories.Films
{
    public interface IFilmRepository
    {
        IEnumerable<Film> Get();
    }
}
