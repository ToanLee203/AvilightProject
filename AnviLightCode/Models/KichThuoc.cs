using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class KichThuoc
    {
        [Key]
        public int MaKichThuoc { get; set; }

        [Required, MaxLength(50)]
        public string TenKichThuoc { get; set; }

        public ICollection<BienTheSanPham> BienThes { get; set; }
    }

}
