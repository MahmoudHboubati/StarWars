using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services.Films
{
    public interface IFilmProvider
    {
        IEnumerable<Film> Get();
        Task<LongestOpeningCrawl> GetLongestOpeningCrawl();
    }
}
