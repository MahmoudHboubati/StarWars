using System.Linq;
using System.Threading.Tasks;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Peoples
{
    public class PeopleRepository : BaseRepository<People>, IPeopleRepository
    {
        public PeopleRepository(StarWarsDbContext context) : base(context) { }

        public async Task<People> GetMostAppeared()
        {
            var groupedByPeople = context.FilmsCharacters.GroupBy(s => s.PeopleId);

            int mostAppearedPersonId = await groupedByPeople
                .OrderByDescending(group => group.Count())
                .Select(group => group.Key)
                .FirstOrDefaultAsync();

            return await context.Peoples.SingleOrDefaultAsync(s => s.Id == mostAppearedPersonId);
        }
    }
}
