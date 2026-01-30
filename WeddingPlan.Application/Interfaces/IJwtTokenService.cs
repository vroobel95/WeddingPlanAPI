using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Application.Interfaces
{
    public interface IJwtTokenService
    {
        string Generate(User user);
    }
}
