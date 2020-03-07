using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SpeciesPeopleEntityConfiguration : IEntityTypeConfiguration<SpeciesPeople>
    {
        public void Configure(EntityTypeBuilder<SpeciesPeople> builder)
        {
            builder.ToTable("species_people");
            builder.Property(e => e.SpeciesId).HasColumnName("species_id");
            builder.Property(e => e.PeopleId).HasColumnName("people_id");
            builder.HasKey(e => new { e.SpeciesId, e.PeopleId });
        }
    }
}
