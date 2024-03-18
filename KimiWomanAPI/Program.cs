using DataBase;
using KimiWomanAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProducts, ProductsRepositorie>();
builder.Services.AddDbContext<KimiWomanContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionSQLServer")));
builder.Services.AddControllers()
           .SetCompatibilityVersion(CompatibilityVersion.Latest)
           .AddJsonOptions(JsonOptions =>
                   JsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
