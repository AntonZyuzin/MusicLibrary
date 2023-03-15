using Microsoft.EntityFrameworkCore;
using MusicLibrary.Domain.Data;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = "Server=(localdb)\\mssqllocaldb; Database=MusicLibraryDB; Trusted_Connection=True";

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddDbContext<MusicLibraryDbContext>(x => x.UseSqlServer(connectionString));


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
