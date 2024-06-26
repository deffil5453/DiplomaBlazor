using BlazorApp10.Data;
using Blazored.Modal;
using DiplomaRealEstate.Components;
using DiplomaRealEstate.Models;
using DiplomaRealEstate.Services.FavoriteServices;
using DiplomaRealEstate.Services.RealEstateServices;
using DiplomaRealEstate.Services.TransactionServices;
using DiplomaRealEstate.Services.UserServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddBlazorBootstrap();
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
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddDefaultIdentity<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.SignIn.RequireConfirmedEmail = false;

})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<RealEstateDbContext>()
    .AddDefaultTokenProviders()
    .AddSignInManager();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");


builder.Services.AddBootstrapBlazor();
var app = builder.Build();
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("ru-RU"),
FallBackToParentUICultures = true,
});
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
