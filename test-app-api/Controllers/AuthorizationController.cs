using MediatR;
using Microsoft.AspNetCore.Mvc;
using test_app_api.Handlers;

namespace test_app_api.Controllers;

[ApiController]
[Route("Authorization")]
public class AuthorizationController
{
    private readonly IMediator _mediator;

    public AuthorizationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("login")]
    public async Task<Unit> Login(UserLogin.Request request)
    {
        var response = await _mediator.Send(request);
        Console.WriteLine($"Hit the endpoint using username {request.UserName} and password {request.PasswordHash}");
        return response;
    }
}