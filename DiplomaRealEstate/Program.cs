using BlazorApp10.Data;
using Blazored.Modal;
using DiplomaRealEstate.Components;
using DiplomaRealEstate.Models;
using DiplomaRealEstate.Services.FavoriteServices;
using DiplomaRealEstate.Services.RealEstateServices;
using DiplomaRealEstate.Services.UserServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<RealEstateDbContext>(options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredModal();
builder.Services.AddScoped<IRealEstateService, RealEstateService>();
builder.Services.AddScoped<IUserInterface, UserServices>();
builder.Services.AddScoped<IFavoriteService, FavoriteService>();
builder.Services.AddDefaultIdentity<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.SignIn.RequireConfirmedEmail = false;

})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<RealEstateDbContext>()
    .AddDefaultTokenProviders()
    .AddSignInManager();
builder.Services.AddBootstrapBlazor();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
