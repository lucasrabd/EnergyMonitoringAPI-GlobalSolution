using EnergyMonitoringAPI.Data;
using EnergyMonitoringAPI.Repositories;
using EnergyMonitoringAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register dependencies
builder.Services.AddSingleton<OracleDbContext>(); // Registra a classe para gerenciamento de conex�o com Oracle
builder.Services.AddScoped<IEnergyRepository, EnergyRepository>(); // Registra o reposit�rio com Oracle
builder.Services.AddScoped<EnergyService>(); // Registra o servi�o

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
