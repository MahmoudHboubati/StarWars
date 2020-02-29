using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("films");
            builder.Property(e => e.EpisodeId).HasColumnName("episode_id");
            builder.Property(e => e.ReleaseDate).HasColumnName("release_date");
            builder.Property(e => e.OpeningCrawl).HasColumnName("opening_crawl");
        }
    }
}
