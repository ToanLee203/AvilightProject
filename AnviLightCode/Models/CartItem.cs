using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("BienTheSanPham")]
        public int MaBienThe { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        public Cart Cart { get; set; }
        public BienTheSanPham BienTheSanPham { get; set; }
    }

}
