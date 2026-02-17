using MediatR;
using WeddingPlan.Application.Commands.Users;
using WeddingPlan.Application.Enums;
using WeddingPlan.Application.Interfaces;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Application.Handlers.Users
{
    public class RegisterUserCommandHandler(
        IUserRepository userRepository,
        IPasswordHasher passwordHasher,
        IEmailService emailService) : IRequestHandler<RegisterUserCommand>
    {
        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await userRepository.GetByEmailAsync(request.Email);
            if (existingUser is not null)
            {
                throw new InvalidOperationException("A user with this email already exists.");
            }

            var hashObject = passwordHasher.HashPassword(request.Password);
            var confirmationToken = Guid.NewGuid().ToString();

            var user = new User
            {                
                Email = request.Email,
                PasswordHash = hashObject.Hash,
                PasswordSalt = hashObject.Salt,
                Name = request.Name,
                IsEmailConfirmed = false,
                ConfirmationToken = confirmationToken,
                CreatedAt = DateTime.UtcNow
            };

            await userRepository.AddAsync(user);
            await emailService.SendEmail(EmailType.RegistrationConfirmation, request.Email, confirmationToken);
        }
    }
}
