namespace WeddingPlan.Application.DTOs.Users
{
    public class RegisterUserDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
    }
}
