// Program.cs - Render-ready version for ASP.NET Core Web API

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Dynamic port support for Render.com
//the following line reads the PORT from environment variables:
var port = Environment.GetEnvironmentVariable("PORT") ?? "5197";
app.Urls.Add($"http://0.0.0.0:{port}");

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
