using Microsoft.AspNetCore.Mvc;
using test_app_api.Handlers;

namespace test_app_api.Controllers;

[ApiController]
[Route("Authorization")]
public class AuthorizationController
{

    [HttpPost("login")]
    public async Task Login(UserLogin.Request request)
    {
        Console.WriteLine($"Hit the endpoint using username {request.UserName} and password {request.PasswordHash}");
    }
}