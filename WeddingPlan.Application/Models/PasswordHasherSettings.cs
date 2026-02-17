namespace WeddingPlan.Application.Models
{
    public class PasswordHasherSettings
    {
        public int SaltSize { get; set; }
        public int HashSize { get; set; }
        public int Iterations { get; set; }
    }
}
