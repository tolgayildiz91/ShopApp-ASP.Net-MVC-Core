using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.WebUI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductDal, EfCoreProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
//app.CustomStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Default hali
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//         name: "products",
//         template: "products/{category?}",
//         defaults: new { controller = "Shop", action = "List" }
//        );
//});

//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//         name: "default",
//         template: "{controller=Home}/{action=Index}/{id?}"
//        );
//});

app.Run();
