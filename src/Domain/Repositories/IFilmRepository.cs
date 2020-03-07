using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories.Films
{
    public interface IFilmRepository
    {
        IEnumerable<Film> Get();
        Task<LongestOpeningCrawl> GetLongestOpeningCrawl();
    }
}
