using Microsoft.EntityFrameworkCore;
using System;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence
{
    public class WeddingPlannerDbContext(DbContextOptions<WeddingPlannerDbContext> options) : DbContext(options)
    {
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestGroup> GuestGroups { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
    }
}
