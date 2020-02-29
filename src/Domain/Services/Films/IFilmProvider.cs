using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Services.Films
{
    public interface IFilmProvider
    {
        IEnumerable<Film> Get();
    }
}
