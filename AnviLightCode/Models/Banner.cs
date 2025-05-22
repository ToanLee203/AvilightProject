using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class Banner
    {
        [Key]
        public int MaBanner { get; set; }

        [Required, MaxLength(255)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public string HinhAnh { get; set; }
    }

}
