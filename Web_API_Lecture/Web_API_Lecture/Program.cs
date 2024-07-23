var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Register MVC controllers
builder.Services.AddEndpointsApiExplorer(); // Register API endpoint explorer
builder.Services.AddSwaggerGen(); // Register Swagger generator

var app = builder.Build(); // Build the application

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Check if in Development environment
{
    app.UseSwagger(); // Enable Swagger middleware
    app.UseSwaggerUI(); // Enable Swagger UI middleware
}

app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseAuthorization(); // Enforce authorization

app.MapControllers(); // Map controller routes

app.Run(); // Run the application