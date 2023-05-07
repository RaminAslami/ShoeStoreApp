using Microsoft.EntityFrameworkCore;
using ShoeStoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IShoeRepository, ShoeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => 
    ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
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
app.UseSession();
//diagnostics, developer. Use this when we are developing
if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

//enables routing, endpoint routing.
//This is the default route "{controller=Home}/{action=Index}/{id?}"
//We can add manual routing see below
app.MapDefaultControllerRoute();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

//if data is empty in the database then add fake data
DbInitializer.Seed(app);

app.Run();


