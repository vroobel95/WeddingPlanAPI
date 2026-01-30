using WeddingPlan.Application.Enums;
using WeddingPlan.Application.Interfaces;

namespace WeddingPlan.Application.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmail(EmailType type, string email, string token)
        {
            throw new NotImplementedException();
        }
    }
}
