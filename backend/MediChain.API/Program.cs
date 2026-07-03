using Microsoft.AspNetCore.Builder;
using MediChain.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ---------------- Services ----------------

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// ---------------- App ----------------

var app = builder.Build();

// ---------------- Middleware ----------------

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ---------------- Controllers ----------------

app.MapControllers();

// ---------------- Root Endpoint ----------------

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        Project = "MediChain API",
        Version = "1.0.0",
        Status = "Running Successfully 🚀"
    });
});

app.Run();