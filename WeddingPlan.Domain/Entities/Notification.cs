using WeddingPlan.Application.Enums;

namespace WeddingPlan.Domain.Entities
{
    public class Notification
    {
        public required int Id { get; set; }
        public required int WeddingId { get; set; }
        public required int GuestId { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public required NotificationType NotificationType { get; set; }
        public required Wedding Wedding { get; set; }
        public required Guest Guest { get; set; }
    }
}
