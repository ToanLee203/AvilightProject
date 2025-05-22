using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("NguoiDung")]
        public int MaNguoiDung { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public NguoiDung NguoiDung { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }

}
