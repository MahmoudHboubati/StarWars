using Domain.Entities.KeyLessEntities.SpeciesEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations.KeyLessEntities
{
    public class SpeciesAggregateEntityConfiguration : IEntityTypeConfiguration<SpeciesAggregate>
    {
        public void Configure(EntityTypeBuilder<SpeciesAggregate> builder)
        {
            builder.HasNoKey();
        }
    }
}
