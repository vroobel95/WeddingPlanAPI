using System.Net;
using System.Net.Mail;
using WeddingPlan.Application.Enums;
using WeddingPlan.Application.Interfaces;
using WeddingPlan.Application.Models;

namespace WeddingPlan.Application.Services
{
    public class EmailService(EmailSettings settings) : IEmailService
    {
        public async Task SendEmail(EmailType type, string email, string token)
        {
            var template = settings.Templates.GetValueOrDefault(type.ToString())
                ?? throw new InvalidOperationException($"Email template not found for type: {type}");

            var body = template.Body.Replace("{token}", token);

            using var client = new SmtpClient(settings.SmtpHost, settings.SmtpPort)
            {
                Credentials = new NetworkCredential(settings.Username, settings.Password),
                EnableSsl = settings.EnableSsl
            };

            var message = new MailMessage(settings.FromEmail, email, template.Subject, body)
            {
                IsBodyHtml = true
            };

            await client.SendMailAsync(message);
        }
    }
}
