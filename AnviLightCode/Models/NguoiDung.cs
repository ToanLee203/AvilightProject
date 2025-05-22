using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class NguoiDung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNguoiDung { get; set; }

        [Required, MaxLength(50)]
        public string TenDangNhap { get; set; }

        [Required, MaxLength(255)]
        public string MatKhau { get; set; }

        [Required, MaxLength(100)]
        public string HoTen { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string DienThoai { get; set; }

        [MaxLength(255)]
        public string DiaChi { get; set; }

        [ForeignKey("LoaiNguoiDung")]
        public int MaLoaiNguoiDung { get; set; }

        public LoaiNguoiDung LoaiNguoiDung { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }

}
