using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class LoaiNguoiDung
    {
        [Key]
        public int MaLoaiNguoiDung { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        public ICollection<NguoiDung> NguoiDungs { get; set; }
    }

}
