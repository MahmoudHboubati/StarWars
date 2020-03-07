using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Constants;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories.Films;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Films
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(StarWarsDbContext context) : base(context)
        {
        }

        public IEnumerable<Film> Get()
        {
            return context.Films.ToList();
        }

        public async Task<LongestOpeningCrawl> GetLongestOpeningCrawl()
        {
            var query = SqlQueries.LONGEST_OPENING_CRAWLS;
            var longestOpeningCrawl = await context.LongestOpeningCrawls.FromSqlRaw<LongestOpeningCrawl>(query).ToListAsync();
            
            return longestOpeningCrawl.FirstOrDefault();
        }
    }
}
