using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplication1.Context;

public class TestAppDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestAppDbContext>
{
    private static IConfiguration Configuration => new ConfigurationBuilder()
        .AddEnvironmentVariables()
#if DEBUG
        .AddUserSecrets(typeof(TestAppDbContext).Assembly, true)
        .AddJsonFile("appsettings.json")
#endif
        .Build();
    public TestAppDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<TestAppDbContext>();
        builder.UseSqlServer(Configuration.GetValue<string>("Db:Sql"));
        
        return new TestAppDbContext(builder.Options);
    }
}