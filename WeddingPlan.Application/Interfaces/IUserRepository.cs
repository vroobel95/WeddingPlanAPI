using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByConfirmationTokenAsync(string token);
        Task AddAsync(User user);
    }
}
