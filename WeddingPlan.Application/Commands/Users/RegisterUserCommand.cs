using MediatR;

namespace WeddingPlan.Application.Commands.Users
{
    public record RegisterUserCommand(
    string Email,
    string Password,
    string Name
) : IRequest;
}
