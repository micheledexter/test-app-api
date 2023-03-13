using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<TestAppDbContext>(options => options.UseSqlServer("Db:Sql"));
app.MapGet("/", () => "Hello World!");

app.Run();