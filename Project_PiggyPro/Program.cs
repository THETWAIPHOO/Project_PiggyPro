using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project_PiggyPro.Components;
using Project_PiggyPro.Components.Account;
using Project_PiggyPro.Data;
using Project_PiggyPro.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<Project_PiggyProContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Project_PiggyProContext")
        ?? throw new InvalidOperationException("Connection string 'Project_PiggyProContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddMvc();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// REMOVED the duplicate AddAuthentication block

// Keep only this Identity configuration
builder.Services.AddIdentity<Project_PiggyProUser, IdentityRole>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Project_PiggyProContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<Project_PiggyProUser>, IdentityNoOpEmailSender>();
builder.Services.AddScoped<AdminService>();
builder.Services.AddScoped<ReportsService>();
builder.Services.AddScoped<GoalService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

app.Run();