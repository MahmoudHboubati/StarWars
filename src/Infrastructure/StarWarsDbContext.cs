using System;
using Domain.Entities;
using Domain.Entities.KeyLessEntities.SpeciesEntities;
using Domain.Entities.SpeciesEntities;
using Infrastructure.Configurations;
using Infrastructure.Configurations.KeyLessEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StarWarsDbContext : DbContext, IStarWarsDbContext
    {
        public StarWarsDbContext(DbContextOptions<StarWarsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new FilmsCharactersEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SpeciesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SpeciesPeopleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SpeciesAggregateEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PlanetLargestPilotEntityConfiguration());
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<FilmsCharacters> FilmsCharacters { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<SpeciesPeople> SpeciesPeople { get; set; }

        public DbSet<SpeciesAggregate> SpeciesAggregate { get; set; }
        public DbSet<PlanetLargestPilot> PlanetLargestPilots { get; set; }
    }
}
