using System;
using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StarWarsDbContext : DbContext, IStarWarsDbContext
    {
        public StarWarsDbContext(DbContextOptions<StarWarsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleEntityConfiguration());
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<People> Peoples { get; set; }
    }
}
