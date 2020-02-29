using DAL.Repositories.Films;
using Domain.Repositories.Films;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFilmRepository, FilmRepository>();
            return services;
        }
    }
}
