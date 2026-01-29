using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class GuestConfiguration : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.DietType).IsRequired();
            builder.HasOne(x => x.AccompanyingGuest).WithMany().HasForeignKey("AccompanyingGuestId");
            builder.Property(x => x.Type).IsRequired();
        }
    }
}
