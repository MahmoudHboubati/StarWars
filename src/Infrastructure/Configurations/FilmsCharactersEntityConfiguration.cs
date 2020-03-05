using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class FilmsCharactersEntityConfiguration : IEntityTypeConfiguration<FilmsCharacters>
    {
        public void Configure(EntityTypeBuilder<FilmsCharacters> builder)
        {
            builder.ToTable("films_characters");
            builder.Property(e => e.FilmId).HasColumnName("film_id");
            builder.Property(e => e.PeopleId).HasColumnName("people_id");
            builder.HasKey(e => new { e.FilmId, e.PeopleId });
        }
    }
}
