using System.Threading.Tasks;
using Domain.Repositories.Films;
using Domain.Services.Films;
using Moq;
using NUnit.Framework;

namespace Domain.Test
{
    public class FilmServiceTest
    {
        private IFilmProvider provider;
        private Mock<IFilmRepository> repository;

        [SetUp]
        public void Setup()
        {
            // create mock version
            repository = new Mock<IFilmRepository>();
            provider = new FilmProvider(repository.Object);
        }

        [Test]
        public async Task GetLongestOpeningCrawlBeingCalled()
        {
            await provider.GetLongestOpeningCrawl();

            repository.Verify(o => o.GetLongestOpeningCrawl(), Times.Once);
        }
    }
}
