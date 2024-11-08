using bcp.project.DataAccess.Interfaces;
using bcp.project.DataAccess.Repositories;
using bcp.project.Services.Interfaces;
using bcp.project.Services.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.
IServiceCollection services = builder.Services;
IWebHostEnvironment env = builder.Environment;

builder.Services.AddCors(options => options
    .AddDefaultPolicy(builder => builder
        .WithOrigins("*")
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()));

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

string sqlConnection = builder.Configuration.GetConnectionString("SQLConnection")!;
builder.Services.AddScoped<ICreditorRepository>(x => new CreditorRepository(sqlConnection));
builder.Services.AddScoped<ICreditorService, CreditorService>();

var app = builder.Build();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/bcp-project/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "info/swagger";
});

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
