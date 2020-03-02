using Infrastructure;

namespace DAL.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected readonly StarWarsDbContext context;

        protected BaseRepository(StarWarsDbContext context)
        {
            this.context = context;
        }
    }
}
