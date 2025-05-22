using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }

        [Required, MaxLength(255)]
        public string TenSanPham { get; set; }

        public string MoTa { get; set; }

        public string HinhAnh { get; set; }

        [ForeignKey("LoaiSanPham")]
        public int MaLoaiSanPham { get; set; }

        public int SoLuongBanRa { get; set; } = 0;
        public int SoLuongTon { get; set; } = 0;

        public LoaiSanPham LoaiSanPham { get; set; }

        public ICollection<BienTheSanPham> BienThes { get; set; }
    }

}
