using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class GuestGroupConfiguration : IEntityTypeConfiguration<GuestGroup>
    {
        public void Configure(EntityTypeBuilder<GuestGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x => x.Guests).WithOne(x => x.GuestGroup).HasForeignKey(x => x.GuestGroupId);
        }
    }
}
