using Domain.Entities;
using Domain.Repositories;

namespace Domain.Services.Peoples
{
    public class PeopleProvider : IPeopleProvider
    {
        private readonly IPeopleRepository repository;

        public PeopleProvider(IPeopleRepository repository)
        {
            this.repository = repository;
        }

        public People GetMostPersonAppeared()
        {
            return repository.GetMostPersonAppeared();
        }
    }
}
