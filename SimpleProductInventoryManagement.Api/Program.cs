
using SimpleProductInventoryManagement.Application;
using SimpleProductInventoryManagement.Persistence;
using SimpleProductInventoryManagement.Identity;
using SimpleProductInventoryManagement.Api.Controllers;
using Microsoft.AspNetCore.Routing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
builder.Logging.AddConsole();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
// Dump all endpoints for debugging
var endpointDataSource = app.Services.GetRequiredService<EndpointDataSource>();
Console.WriteLine("=== Registered Endpoints ===");
foreach (var endpoint in endpointDataSource.Endpoints)
{
    var routeEndpoint = endpoint as RouteEndpoint;
    if (routeEndpoint != null)
    {
        var httpMethods = routeEndpoint.Metadata
            .OfType<HttpMethodMetadata>()
            .FirstOrDefault()?.HttpMethods;

        var pattern = routeEndpoint.RoutePattern.RawText;
        Console.WriteLine($"{string.Join(",", httpMethods ?? new[] { "N/A" })} => {pattern}");
    }
    else
    {
        Console.WriteLine(endpoint.DisplayName);
    }
}
Console.WriteLine("=== End of Endpoints ===");

app.Run();
