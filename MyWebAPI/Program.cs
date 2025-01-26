using Microsoft.EntityFrameworkCore;
using MyWebAPI.Data;
using MyWebAPI.Repositories;
using MyWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// ใช้ In-Memory Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

// ลงทะเบียน IRepository และ ProductService
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ProductService>();

// เพิ่มการตั้งค่า Controllers
builder.Services.AddControllers();

var app = builder.Build();

// การสร้างฐานข้อมูล (ในหน่วยความจำ)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

// การตั้งค่า Routing สำหรับ Controllers
app.Urls.Add("http://0.0.0.0:5153");

app.MapControllers();

app.Run();
