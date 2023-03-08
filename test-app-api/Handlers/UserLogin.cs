using MediatR;
using test_app_api.Models;

namespace test_app_api.Handlers;

public class UserLogin : AsyncRequestHandler<UserLogin.Request>
{
    public record Request(string UserName, string PasswordHash) : IRequest;

    protected override async Task Handle(Request request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Logging in with username {request.UserName} and password {request.PasswordHash}");
    }
}