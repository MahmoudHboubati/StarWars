using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations.KeyLessEntities
{
    public class PlanetLargestPilotEntityConfiguration: IEntityTypeConfiguration<PlanetLargestPilot>
    {
        public void Configure(EntityTypeBuilder<PlanetLargestPilot> builder)
        {
            builder.HasNoKey();
        }
    }
}
