using BlazorApp.Logic.DataStorage;
using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Interfaces;
using BlazorApp.Logic.Models;
using BlazorApp.Logic.Repositories;
using BlazorApp.Logic.Services;
using BlazorApp.ServerApp.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<IRepository<User>, UserService>();
builder.Services.AddSingleton<IAccountService, AccountService>();
builder.Services.AddSingleton<IPasswordHasher<Client>, PasswordHasher<Client>>();//uzyjemy tego do hashowania hasel

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var client = UsersStorage.Clients.FirstOrDefault();//set password
    if (client != null)
    {
        PasswordHasher<Client> _passwordHasher = new PasswordHasher<Client>();
        var passworhasher = _passwordHasher.HashPassword(client, "admin");
        client.PasswordHash = passworhasher;
    }
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
