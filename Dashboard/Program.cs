using Dashboard.Brokers.Storages;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<StorageBroker>();

var app = builder.Build();

app.MapControllerRoute(
    name: "Def",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
