using WeddingPlan.Application.Models;

namespace WeddingPlan.Application.Interfaces
{
    public interface IPasswordHasher
    {
        HashObject HashPassword(string password);
        bool VerifyPassword(string hash, string salt, string password);
    }
}
