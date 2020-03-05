using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PeopleEntityConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("people");
            builder.Property(e => e.BirthYear).HasColumnName("birth_year");
            builder.Property(e => e.EyeColor).HasColumnName("eye_color");
            builder.Property(e => e.HairColor).HasColumnName("hair_color");
            builder.Property(e => e.SkinColor).HasColumnName("skin_color");
        }
    }
}
