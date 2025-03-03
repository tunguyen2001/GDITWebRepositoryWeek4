using Microsoft.EntityFrameworkCore;
using WebApiRepositoryWeek4.Data;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories;
using WebApiRepositoryWeek4.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

 string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);


app.UseHttpsRedirection();


app.MapControllers();

app.Run();


// it's master branch is code


// add sort code