namespace WeddingPlan.Domain.Entities
{
    public class PhotoGallery
    {
        public required int Id { get; set; }
        public required int WeddingId { get; set; }
        public required string PhotoUrl { get; set; }
        public string Password { get; set; } = string.Empty;
        public required Wedding Wedding { get; set; }
    }
}
