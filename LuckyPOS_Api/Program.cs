using LuckySystem_Api.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Logs
builder.Host.UseSerilog((ctx, config) =>
{
    config.WriteTo.Console();
    config.WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day);
});

// Db Context
builder.Services.AddDbContext<LuckyGym_Context>(
    opciones => opciones.UseSqlServer("name=DefaultConnection"));
builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {        
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
