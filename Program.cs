using ShoeStoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IShoeRepository, MockShoeRepository>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();

//enables MVC in the collection
builder.Services.AddControllersWithViews();


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

app.Run();


