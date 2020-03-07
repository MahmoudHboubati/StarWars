using Domain.Services.Films;
using Domain.Services.Peoples;
using Domain.Services.Planets;
using Domain.Services.Species;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFilmProvider, FilmProvider>();
            services.AddScoped<IPeopleProvider, PeopleProvider>();
            services.AddScoped<ISpeciesProvider, SpeciesProvider>();
            services.AddScoped<IPlanetProvider, PlanetProvider>();

            return services;
        }
    }
}
