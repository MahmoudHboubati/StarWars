using System;
using Domain.Entities;
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
        }

        public DbSet<Film> Films { get; set; }
    }
}
