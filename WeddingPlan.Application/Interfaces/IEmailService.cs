using WeddingPlan.Application.Enums;

namespace WeddingPlan.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(EmailType type, string email, string token);
    }
}
