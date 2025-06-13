var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(); // wwwroot'taki dosyalarý servis eder
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.MapWhen(context => context.Request.Path.StartsWithSegments("/client"), builder =>
{
    builder.UseRouting();
    builder.UseEndpoints(endpoints =>
    {
        // React SPA fallback (client/index.html yerine, senin HomeController.Index olabilir)
        endpoints.MapFallbackToController("Index", "React");
    });
});

app.Run();