using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StarWarsDbContext : DbContext, IStarWarsDbContext
    {
        public StarWarsDbContext(DbContextOptions<StarWarsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Film>(entity =>
            {
                entity.ToTable("films");
                entity.Property(e => e.EpisodeId).HasColumnName("episode_id");
                entity.Property(e => e.ReleaseDate).HasColumnName("release_date");
                entity.Property(e => e.OpeningCrawl).HasColumnName("opening_crawl");
            });
        }

        public DbSet<Film> Films { get; set; }
    }
}
