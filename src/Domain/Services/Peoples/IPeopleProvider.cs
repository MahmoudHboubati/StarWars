using Domain.Entities;

namespace Domain.Services.Peoples
{
    public interface IPeopleProvider
    {
        People GetMostAppeared();
    }
}
