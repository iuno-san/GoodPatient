using Microsoft.EntityFrameworkCore;
using GoodPatient.Infrastructure.Persistance;
using GoodPatient.Infrastructure.Extensions;
using GoodPatient.Infrastructure.Seeders;
using Microsoft.AspNetCore.Identity;
using GoodPatient.Application.GoodPatient.Commands.DeleteGoodPatient;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using GoodPatient.Application.GoodPatient;
using GoodPatient.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddApplication();

var app = builder.Build();

var scope = app.Services.CreateScope();

var seeder = scope.ServiceProvider.GetRequiredService<GoodPatientSeeder>();

await seeder.Seed();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithRedirects("/Home/Error?statuscode={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();
