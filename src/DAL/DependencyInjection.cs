using DAL.Repositories.Films;
using DAL.Repositories.Peoples;
using DAL.Repositories.Planets;
using DAL.Repositories.SpeciesRepositories;
using Domain.Repositories;
using Domain.Repositories.Films;
using Domain.Repositories.Planets;
using Domain.Repositories.SpeciesRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<ISpeciesRepository, SpeciesRepository>();
            services.AddScoped<IPlanetRepository, PlanetRepository>();
            return services;
        }
    }
}
