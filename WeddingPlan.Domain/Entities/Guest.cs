using WeddingPlan.Domain.Enums;

namespace WeddingPlan.Domain.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public required int GuestGroupId { get; set; }
        public required string Name { get; set; }
        public string Email { get; set; } = string.Empty;
        public required DietType DietType { get; set; }
        public required bool RequiresAccommodation { get; set; }
        public required bool RequiresTransportation { get; set; }
        public string Notes { get; set; } = string.Empty;
        public Guest? AccompanyingGuest { get; set; }
        public required GuestType Type { get; set; }
        public required GuestGroup GuestGroup { get; set; }
    }
}
