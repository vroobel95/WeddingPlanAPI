using Microsoft.EntityFrameworkCore;
using WeddingPlan.Application.Commands.Users;
using WeddingPlan.Application.Interfaces;
using WeddingPlan.Application.Services;
using WeddingPlan.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<WeddingPlannerDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default"),
        x => x.MigrationsAssembly("WeddingPlan.Infrastructure")
    ));

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(RegisterUserCommand).Assembly));

builder.Services.AddSingleton<IJwtTokenService>(sp => new JwtTokenService(
    secretKey: builder.Configuration["Jwt:SecretKey"]!,
    issuer: builder.Configuration["Jwt:Issuer"]!,
    audience: builder.Configuration["Jwt:Audience"]!
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
