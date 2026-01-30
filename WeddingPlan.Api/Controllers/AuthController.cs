using Microsoft.AspNetCore.Mvc;
using WeddingPlan.Application.Commands.Users;
using WeddingPlan.Application.DTOs.Users;

namespace WeddingPlan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto userDto)
        {
            return await Send(new RegisterUserCommand(
            userDto.Email,
            userDto.Password,
            userDto.Name));
        }
    }
}
