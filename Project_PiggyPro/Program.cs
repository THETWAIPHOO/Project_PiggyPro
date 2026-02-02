using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Project_PiggyPro.Components;
using Project_PiggyPro.Components.Account;
using Project_PiggyPro.Data;
using Project_PiggyPro.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ FIXED: Get connection string properly
var connectionString = builder.Configuration.GetConnectionString("Project_PiggyProContext")
    ?? throw new InvalidOperationException("Connection string 'Project_PiggyProContext' not found.");

// ✅ FIXED: Register DbContextFactory first (for thread-safe operations)
builder.Services.AddDbContextFactory<Project_PiggyProContext>(options =>
    options.UseSqlServer(connectionString));

// Add other services
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddMvc();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Authentication & Authorization
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// ✅ IMPORTANT: Register notification service
builder.Services.AddScoped<IInAppNotificationService, InAppNotificationService>();

// Identity configuration
builder.Services.AddIdentity<Project_PiggyProUser, IdentityRole>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Project_PiggyProContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Other services
builder.Services.AddSingleton<IEmailSender<Project_PiggyProUser>, IdentityNoOpEmailSender>();
builder.Services.AddScoped<AdminService>();
builder.Services.AddScoped<ReportsService>();
builder.Services.AddScoped<GoalService>();
builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
else
{
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

app.MapControllers();

app.Run();


