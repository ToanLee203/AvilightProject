using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnviLightCode.Models
{
    public class Blog
    {
        [Key]
        public int MaBlog { get; set; }

        [Required, MaxLength(255)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public string HinhAnh { get; set; }
    }

}
