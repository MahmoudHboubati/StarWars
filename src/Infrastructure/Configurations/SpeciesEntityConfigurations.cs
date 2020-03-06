using Domain.Entities.SpeciesEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SpeciesEntityConfigurations
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.ToTable("species");
            builder.Property(e => e.AverageHeight).HasColumnName("average_height");
            builder.Property(e => e.AverageLifespan).HasColumnName("average_lifespan");
            builder.Property(e => e.EyeColors).HasColumnName("eye_colors");
            builder.Property(e => e.HairColors).HasColumnName("hair_colors");
            builder.Property(e => e.SkinColors).HasColumnName("skin_colors");
        }
    }
}
