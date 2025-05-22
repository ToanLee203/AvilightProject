using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaChiTiet { get; set; }

        [ForeignKey("DonHang")]
        public int MaDonHang { get; set; }

        [ForeignKey("BienTheSanPham")]
        public int MaBienTheSanPham { get; set; }

        public int SoLuong { get; set; }

        public decimal Gia { get; set; }

        public DonHang DonHang { get; set; }
        public BienTheSanPham BienTheSanPham { get; set; }
    }

}
