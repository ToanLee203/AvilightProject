using Microsoft.EntityFrameworkCore;
using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.Repository;
using AnviLightCode.IService;
using AnviLightCode.Service; // ✅ Đảm bảo có namespace chứa DbContext của bạn

namespace AnviLightCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            var connectionString = builder.Configuration.GetConnectionString("myCnn");
            builder.Services.AddDbContext<AnvilightDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddRazorPages();
            // Đăng ký Repository
            builder.Services.AddScoped<IBannerRepository, BannerRepository>();
            builder.Services.AddScoped<IBlogRepository, BlogRepository>();
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
            builder.Services.AddScoped<IChiTietDonHangRepository, ChiTietDonHangRepository>();
            builder.Services.AddScoped<IDonHangRepository, DonHangRepository>();
            builder.Services.AddScoped<IKichThuocRepository, KichThuocRepository>();
            builder.Services.AddScoped<ILoaiNguoiDungRepository, LoaiNguoiDungRepository>();
            builder.Services.AddScoped<ILoaiSanPhamRepository, LoaiSanPhamRepository>();
            builder.Services.AddScoped<IMauSacRepository, MauSacRepository>();
            builder.Services.AddScoped<INguoiDungRepository, NguoiDungRepository>();
            builder.Services.AddScoped<ISanPhamRepository, SanPhamRepository>();
            builder.Services.AddScoped<IBienTheSanPhamRepository, BienTheSanPhamRepository>();
            builder.Services.AddScoped<ITrangThaiDonHangRepository, TrangThaiDonHangRepository>();
            // Đăng ký Service
            builder.Services.AddScoped<IBannerService, BannerService>();
            builder.Services.AddScoped<IBlogService, BlogService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<ICartItemService, CartItemService>();
            builder.Services.AddScoped<IChiTietDonHangService, ChiTietDonHangService>();
            builder.Services.AddScoped<IDonHangService, DonHangService>();
            builder.Services.AddScoped<IKichThuocService, KichThuocService>();
            builder.Services.AddScoped<ILoaiNguoiDungService, LoaiNguoiDungService>();
            builder.Services.AddScoped<ILoaiSanPhamService, LoaiSanPhamService>();
            builder.Services.AddScoped<IMauSacService, MauSacService>();
            builder.Services.AddScoped<INguoiDungService, NguoiDungService>();
            builder.Services.AddScoped<ISanPhamService, SanPhamService>();
            builder.Services.AddScoped<IBienTheSanPhamService, BienTheSanPhamService>();
            builder.Services.AddScoped<ITrangThaiDonHangService, TrangThaiDonHangService>();

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
            app.UseSession();
            app.UseAuthorization();

            app.MapRazorPages();
            app.MapFallbackToPage("/User/Home");

            app.Run();
        }
    }
}
