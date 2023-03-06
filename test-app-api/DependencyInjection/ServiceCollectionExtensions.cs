using System.Reflection;
using MediatR;
using test_app_api.Models;

namespace test_app_api.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(IServiceCollection services)
    {
        return services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(User).Assembly);
    }
}