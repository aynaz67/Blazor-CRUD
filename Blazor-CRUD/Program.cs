using Blazor_CRUD.Data;
using DataAccess.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();


var cnn = builder.Configuration.GetConnectionString("CustomerCnn");

//First Dependency injection
builder.Services.AddDbContext<CustomerDBContext>(options => options.UseSqlServer(cnn));

//Second Dependency Injection
// AddScope, AddTransient, Add...
//in whole application for ICustomerRepository , one CustomerRepository is created
////builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();

var app = builder.Build();

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
