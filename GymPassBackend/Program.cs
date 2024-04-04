using GymPassBackend.DataAccess;
using GymPassBackend.Interfaces;
using GymPassBackend.Repositories;
using GymPassBackend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

// Register services and repositories
builder.Services.AddScoped<IService, Service>();
builder.Services.AddScoped<IRepository, Repository>();


// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "customPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("customPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
