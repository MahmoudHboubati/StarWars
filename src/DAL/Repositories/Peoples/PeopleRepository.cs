using System.Linq;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace DAL.Repositories.Peoples
{
    public class PeopleRepository : BaseRepository<People>, IPeopleRepository
    {
        public PeopleRepository(StarWarsDbContext context) : base(context) { }

        public People GetMostAppeared()
        {
            var groupedByPeople = context.FilmsCharacters.GroupBy(s => s.PeopleId);

            int mostAppearedPersonId = groupedByPeople
                .OrderByDescending(group => group.Count())
                .Select(group => group.Key)
                .FirstOrDefault();

            return context.Peoples.SingleOrDefault(s => s.Id == mostAppearedPersonId);
        }
    }
}
