using WeddingPlan.Domain.Enums;

namespace WeddingPlan.Domain.Entities
{
    public class Location
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public string Latitude { get; set; } = string.Empty;
        public string Longitude { get; set; } = string.Empty;
        public required LocationType LocationType { get; set; }
    }
}
