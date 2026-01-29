namespace WeddingPlan.Domain.Entities
{
    public class GuestGroup
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Guest> Guests { get; set; } = new List<Guest>();
    }
}
