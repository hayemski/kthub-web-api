using KtHub.Contracts.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KtHub.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [Route("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok();
    }

    [Route("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok();
    }
}
