using Microsoft.EntityFrameworkCore;
using AnviLightCode.Models; // ✅ Đảm bảo có namespace chứa DbContext của bạn

namespace AnviLightCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ Đọc connection string từ appsettings.json hoặc appsettings.Development.json
            var connectionString = builder.Configuration.GetConnectionString("myCnn");

            // ✅ Cấu hình DbContext dùng SQL Server
            builder.Services.AddDbContext<AnvilightDbContext>(options =>
                options.UseSqlServer(connectionString));

            // ✅ Thêm Razor Pages
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // ✅ Cấu hình pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.MapRazorPages();
            app.MapFallbackToPage("/User/Home");

            app.Run();
        }
    }
}
