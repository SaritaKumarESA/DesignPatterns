
using FacadeDesignPattern;
using FacadeDesignPattern.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);


builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddTransient<IShippingService, ShippingService>();
builder.Services.AddTransient<SystemFacade>();

using IHost app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Starting application");

var systemFacade = app.Services.GetRequiredService<SystemFacade>();
systemFacade.ProcessOrder("Product 1", 10, "Credit Card", 100);
// See https://aka.ms/new-console-template for more information
Console.ReadLine();

await app.RunAsync();

logger.LogInformation("Application is running");