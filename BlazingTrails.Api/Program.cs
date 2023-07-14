var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable debugging of Blazor WebAssembly code:
    app.UseWebAssemblyDebugging();
}

app.UseHttpsRedirection();

// Enable the API to server the Blazor app:
app.UseBlazorFrameworkFiles();

// Allow the API to serve static files:
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

// Serve up the index.html file if a request doesn't match a controller:
app.MapFallbackToFile("index.html");

app.Run();
