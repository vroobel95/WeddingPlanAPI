using WeddingPlan.Domain.Enums;

namespace WeddingPlan.Domain.Entities
{
    public class Invitation
    {
        public required int Id { get; set; }
        public required int WeddingId { get; set; }
        public required int GuestId { get; set; }
        public required InvitationStatus InvitationStatus { get; set; }
        public string Token { get; set; } = string.Empty;
        public required DateTime SentAt { get; set; }
        public required DateTime RespondedAt { get; set; }
        public required Guest Guest { get; set; }
    }
}
