using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//Dependency Injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString ,ServerVersion.AutoDetect(connectionString) )
);
//register syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCekx3QXxbf1x0ZFdMY1RbRHVPIiBoS35RckVgWHpfdHFURWJeWEJ0");
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRouting();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Create}/{id?}");
app.MapRazorPages();
app.Run();