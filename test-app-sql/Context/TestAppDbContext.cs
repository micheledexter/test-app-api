using Microsoft.EntityFrameworkCore;
using test_app_api.Models;

namespace WebApplication1.Context;

public class TestAppDbContext : DbContext
{
    protected TestAppDbContext()
    {
    }

    public TestAppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
}