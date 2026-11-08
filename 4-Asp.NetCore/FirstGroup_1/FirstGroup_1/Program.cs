
using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Application.Abstractions.Services;
using FirstGroup_1.Application.Security;
using FirstGroup_1.Infrastructure.Data;
using FirstGroup_1.Infrastructure.Repositories;
using FirstGroup_1.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IEmployeeRepository),typeof(EmployeeRepository));
builder.Services.AddScoped(typeof(IUsersRepository), typeof(UsersRepository));
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
builder.Services.AddScoped(typeof(IEmployeeService), typeof(EmployeeService));



builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
    {
        options.LoginPath         = "/Account/Login";
        options.LogoutPath        = "/Account/Logout";
        options.AccessDeniedPath  = "/Account/AccessDenied";
        options.ExpireTimeSpan    = TimeSpan.FromMinutes(30);
        options.SlidingExpiration = true;
        options.Cookie.Name       = "CompanyManagement.Auth";
        options.Cookie.HttpOnly   = true;
    });
builder.Services.AddAuthorization(options =>
{
   foreach(string permission in PermissionsNames.AllPermissions)
   {
       options.AddPolicy(permission,
           policy => policy.RequireClaim(PermissionsNames.ClaimType, permission));
    }
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
