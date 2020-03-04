using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services.Peoples
{
    public interface IPeopleProvider
    {
        Task<People> GetMostAppeared();
    }
}
