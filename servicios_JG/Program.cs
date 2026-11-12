using aplicaciones_JG.implementaciones;
using aplicaciones_JG.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IHabitacionesAplicacion, HabitacionesAplicacion>();
builder.Services.AddScoped<IConexion, Conexion>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
