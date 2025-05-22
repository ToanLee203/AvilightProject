using Microsoft.EntityFrameworkCore;
using System;

namespace AnviLightCode.Models
{
    public class AnvilightDbContext : DbContext
    {
        public AnvilightDbContext(DbContextOptions<AnvilightDbContext> options) : base(options) { }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<BienTheSanPham> BienTheSanPhams { get; set; }
        public DbSet<KichThuoc> KichThuocs { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Unique constraint: mỗi Cart chỉ có 1 biến thể duy nhất
            modelBuilder.Entity<CartItem>()
                .HasIndex(c => new { c.CartId, c.MaBienThe })
                .IsUnique();
        }
    }
}
