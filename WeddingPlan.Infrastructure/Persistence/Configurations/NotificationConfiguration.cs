using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.WeddingId).IsRequired();
            builder.Property(x => x.GuestId).IsRequired();
            builder.HasOne(x => x.Guest).WithMany().HasForeignKey(x => x.GuestId);
            builder.HasOne(x => x.Wedding).WithMany().HasForeignKey(x => x.WeddingId);
        }
    }
}
