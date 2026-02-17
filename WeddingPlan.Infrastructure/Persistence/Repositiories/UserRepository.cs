using Microsoft.EntityFrameworkCore;
using WeddingPlan.Application.Interfaces;
using WeddingPlan.Domain.Entities;

namespace WeddingPlan.Infrastructure.Persistence.Repositiories
{
    public class UserRepository(WeddingPlannerDbContext context) : IUserRepository
    {
        public async Task AddAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<User?> GetByConfirmationTokenAsync(string token)
        {
            return await context.Users
                .FirstOrDefaultAsync(u => u.ConfirmationToken == token);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
