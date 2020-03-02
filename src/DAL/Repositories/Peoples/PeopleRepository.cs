using DAL.Repositories.Base;
using Domain.Repositories;
using Infrastructure;

namespace DAL.Repositories.Peoples
{
    public class PeopleRepository : BaseRepository, IPeopleRepository
    {
        public PeopleRepository(StarWarsDbContext context) : base(context)
        {
        }
    }
}
