using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Configurations
{
    public class PhotoGalleryConfiguration : IEntityTypeConfiguration<PhotoGallery>
    {
        public void Configure(EntityTypeBuilder<PhotoGallery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.WeddingId).IsRequired();
            builder.HasOne(x => x.Wedding).WithOne(x => x.PhotoGallery);
        }
    }
}
