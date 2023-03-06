using Microsoft.AspNetCore.Identity;
using test_app_api.Models.Base;

namespace test_app_api.Models;

public class User : IdentityUser<Guid>, IGuidIdentifier
{
    public string Name { get; set; }
}