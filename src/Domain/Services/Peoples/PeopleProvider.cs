using Domain.Entities;
using Domain.Repositories;

namespace Domain.Services.Peoples
{
    public class PeopleProvider : IPeopleProvider
    {
        private readonly IPeopleRepository repository;

        public People GetMostPersonAppeared()
        {
            throw new System.NotImplementedException();
        }
    }
}
