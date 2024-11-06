using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Components;
using WiredBrainCoffee.EmployeeManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<EmployeeManagerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
    
}

if (app.Environment.IsDevelopment())
{
    await EnsureDatabaseIsMigrated(app.Services);
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

async Task EnsureDatabaseIsMigrated(IServiceProvider appServices)
{
    using var scope = appServices.CreateScope();

    await using var context = scope.ServiceProvider.GetRequiredService<EmployeeManagerDbContext>();
    
    await context.Database.MigrateAsync();
}