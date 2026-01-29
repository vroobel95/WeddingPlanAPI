namespace WeddingPlan.Domain.Entities
{
    public class Wedding
    {
        public required int Id { get; set; }
        public DateTime Date { get; set; }
        public required Location CeremonyVenue { get; set; }
        public Location? ReceptionVenue { get; set; }
        public DateTime? RSVPDate { get; set; }
        public PhotoGallery? PhotoGallery { get; set; }
    }
}
