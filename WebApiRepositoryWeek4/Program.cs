using Microsoft.EntityFrameworkCore;
using WebApiRepositoryWeek4.Data;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories.ProductRepository;
using WebApiRepositoryWeek4.Repositories.RepositoryBase;
using WebApiRepositoryWeek4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductService>();

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
