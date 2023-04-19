using Application.Interfaces;
using Application.Services;
using DataAccessSql;
using DataAccessSql.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

//Repositories
builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

//Services
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

// CORS policy
builder.Services.AddCors(options => options.AddDefaultPolicy(b =>
{
    b.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));

// Add services to the container.

var app = builder.Build();
app.MapControllers();

// Add swagger
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDo List API");
    c.RoutePrefix = string.Empty;
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors();

app.Run();

