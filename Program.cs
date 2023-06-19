using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//для БД
builder.Services.AddDbContext<EF_DataContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("VapeShopDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//контроллер  = имя_контроллера_по_умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=First}/{action=Index}/{id?}");

app.Run();
