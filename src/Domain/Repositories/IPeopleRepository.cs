using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPeopleRepository
    {
        People GetMostPersonAppeared();
    }
}
