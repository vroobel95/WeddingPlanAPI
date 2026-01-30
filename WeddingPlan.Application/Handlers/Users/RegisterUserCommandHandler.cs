using MediatR;
using WeddingPlan.Application.Commands.Users;

namespace WeddingPlan.Application.Handlers.Users
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        public RegisterUserCommandHandler()
        {
            
        }

        public Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
