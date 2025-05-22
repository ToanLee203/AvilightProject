using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class MauSac
    {
        [Key]
        public int MaMauSac { get; set; }

        [Required, MaxLength(50)]
        public string TenMauSac { get; set; }

        public ICollection<BienTheSanPham> BienThes { get; set; }
    }

}
