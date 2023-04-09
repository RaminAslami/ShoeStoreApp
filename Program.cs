using Microsoft.EntityFrameworkCore;
using ShoeStoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IShoeRepository, ShoeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

//enables MVC in the collection
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ShoeStoreDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:ShoeStoreDbContext"]);
});

var app = builder.Build();
//middleware component comes after the builder.Build()

//looks for the WWWROOT 
app.UseStaticFiles();
//diagnostics, developer. Use this when we are developing
if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

//enables routing, endpoint routing.
app.MapDefaultControllerRoute();

//if data is empty in the database then add fake data
DbInitializer.Seed(app);

app.Run();


