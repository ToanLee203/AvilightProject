using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class BienTheSanPham
    {
        [Key]
        public int MaBienTheSanPham { get; set; }

        [ForeignKey("SanPham")]
        public int MaSanPham { get; set; }

        [ForeignKey("KichThuoc")]
        public int MaKichThuoc { get; set; }

        [ForeignKey("MauSac")]
        public int MaMauSac { get; set; }

        public decimal Gia { get; set; }

        public int SoLuongTon { get; set; } = 0;

        public SanPham SanPham { get; set; }
        public KichThuoc KichThuoc { get; set; }
        public MauSac MauSac { get; set; }

        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }

}
