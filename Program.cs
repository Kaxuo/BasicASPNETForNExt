using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Testing.Contexts;
using Testing.Interface;
using Testing.Models.CustomerFiles;
using Testing.Profile;
using Testing.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<KaxouDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ICustomerService,CustomerRepository>(); // Add this line
builder.Services.AddScoped<IOrderService, OrderRepository>(); // Add this line
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
