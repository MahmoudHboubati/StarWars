using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations.KeyLessEntities
{
    public class LongestOpeningCrawlEntityConfiguration : IEntityTypeConfiguration<LongestOpeningCrawl>
    {
        public void Configure(EntityTypeBuilder<LongestOpeningCrawl> builder)
        {
            builder.HasNoKey();
        }
    }
}
