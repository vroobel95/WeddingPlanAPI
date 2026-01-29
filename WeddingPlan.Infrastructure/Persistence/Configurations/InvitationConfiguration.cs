using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SentAt).IsRequired();
            builder.Property(x => x.InvitationStatus).IsRequired();
            builder.Property(x => x.GuestId).IsRequired();
            builder.HasOne(x => x.Guest).WithMany().HasForeignKey(x => x.GuestId);
        }
    }
}
