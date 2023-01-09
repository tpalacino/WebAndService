using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

// Create the builder from the WebApplication but don't call built yet
var appBuilder = WebApplication.CreateBuilder(args);

// Add the windows service class as a HostedService to the service collection on the builder
appBuilder.Services.AddHostedService<Service>();

// Build the builder to get a web application we can map endpoints to
var app = appBuilder.Build();

// Map an endpoint
app.MapGet("/", () => "Hello World!");

// Run the web application 
app.Run();
