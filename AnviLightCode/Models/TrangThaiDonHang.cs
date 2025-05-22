using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class TrangThaiDonHang
    {
        [Key]
        public int MaTrangThai { get; set; }

        [Required, MaxLength(50)]
        public string TenTrangThai { get; set; }

        public ICollection<DonHang> DonHangs { get; set; }
    }

}
