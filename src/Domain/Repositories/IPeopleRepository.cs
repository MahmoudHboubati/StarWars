using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPeopleRepository
    {
        Task<People> GetMostAppeared();
    }
}
