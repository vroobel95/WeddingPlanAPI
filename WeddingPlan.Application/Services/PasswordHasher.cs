using System.Security.Cryptography;
using WeddingPlan.Application.Interfaces;
using WeddingPlan.Application.Models;

namespace WeddingPlan.Application.Services
{
    public class PasswordHasher(PasswordHasherSettings settings) : IPasswordHasher
    {
        private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA256;

        public HashObject HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(settings.SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, settings.Iterations, Algorithm, settings.HashSize);

            return new HashObject
            {
                Hash = Convert.ToBase64String(hash),
                Salt = Convert.ToBase64String(salt)
            };
        }

        public bool VerifyPassword(string hash, string salt, string password)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var hashBytes = Convert.FromBase64String(hash);
            var inputHash = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, settings.Iterations, Algorithm, settings.HashSize);

            return CryptographicOperations.FixedTimeEquals(hashBytes, inputHash);
        }
    }
}
