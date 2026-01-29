using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class WeddingConfiguration : IEntityTypeConfiguration<Wedding>
    {
        public void Configure(EntityTypeBuilder<Wedding> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CeremonyVenue).IsRequired();
            builder.Property(x => x.RSVPDate).IsRequired();
            builder.Property(x => x.Date).IsRequired();
        }
    }
}
