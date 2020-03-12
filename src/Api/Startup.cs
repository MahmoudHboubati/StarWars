using System;
using Api.GraphQL;
using Api.GraphQL.Schemas;
using AutoMapper;
using DAL;
using Domain;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Api
{
    public class Startup
    {
        const string AllowAllOrigins = "ALLOW_STARWARS_FE";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            CorsConfigurations(services);
            services.AddGraphQLServices();

            services.AddInfrastructure(Configuration);
            services.AddDataAccessServices(Configuration);
            services.AddDomainServices(Configuration);

            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
        }

        private void CorsConfigurations(IServiceCollection services)
        {
            //Todo: implement this as configurations to allow only trusted consumers
            services.AddCors(options =>
            {
                options.AddPolicy(AllowAllOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .WithMethods("GET", "PUT", "POST", "DELETE")
                            .AllowAnyHeader();
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Allow Cors
            app.UseCors(AllowAllOrigins);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
                app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseGraphQL<StarWarsSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
