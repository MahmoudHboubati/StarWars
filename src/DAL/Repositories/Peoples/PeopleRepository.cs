using System.Linq;
using DAL.Repositories.Base;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace DAL.Repositories.Peoples
{
    public class PeopleRepository : BaseRepository<People>, IPeopleRepository
    {
        public PeopleRepository(StarWarsDbContext context) : base(context)
        {
        }

        public People GetMostPersonAppeared()
        {
            return context.Peoples.FirstOrDefault();
        }
    }
}
