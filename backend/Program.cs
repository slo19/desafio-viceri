using backend.Repositories;
using backend.Repositories.Interfaces;
using backend.Models;
using backend.Services;
using backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISuperpoderService, SuperpoderService>();
builder.Services.AddScoped<ISuperpoderRepository, SuperpoderRepository>();
builder.Services.AddScoped<IHeroiService, HeroiService>();
builder.Services.AddScoped<IHeroiRepository, HeroiRepository>();
builder.Services.AddDbContext<backendContext>(opts => opts.UseInMemoryDatabase("test"));

builder.Services.AddCors(opts =>
{
    opts.AddPolicy("SpecificOrigins",
            builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .WithMethods("GET", "POST", "DELETE", "PUT", "OPTIONS");
            });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseCors("SpecificOrigins");

app.UseHttpsRedirection();

app.MapControllers();
app.Run();

