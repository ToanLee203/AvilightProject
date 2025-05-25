using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int MaLoaiSanPham { get; set; }

        [Required, MaxLength(50)]
        public string TenLoai { get; set; }

        public int KieuSanPham { get; set;  }

        public ICollection<SanPham> SanPhams { get; set; }
    }

}
