using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HeroManagement.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HeroManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HeroManagementContext") ?? throw new InvalidOperationException("Connection string 'HeroManagementContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Heroes/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Heroes}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
