using Microsoft.AspNetCore.Identity;
using test_app_api.Models.Base;

namespace test_app_api.Models;

public class User : IdentityUser<Guid>, IGuidIdentifier
{
    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }
    public string Name { get; set; }
    public string Password { get; set; }
}