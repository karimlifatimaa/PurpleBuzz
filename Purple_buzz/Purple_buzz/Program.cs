using Microsoft.EntityFrameworkCore;
using Purple_buzz.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=USER\\SQLEXPRESS;database=BB207_MVC_project;Trusted_Connection=true;Integrated security=true;TrustServerCertificate=true");
}
);
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
