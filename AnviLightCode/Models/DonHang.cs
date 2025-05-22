using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnviLightCode.Models
{
    public class DonHang
    {
        [Key]
        public int MaDonHang { get; set; }

        [ForeignKey("NguoiDung")]
        public int MaNguoiDung { get; set; }

        public DateTime NgayDat { get; set; } = DateTime.Now;

        [ForeignKey("TrangThaiDonHang")]
        public int MaTrangThai { get; set; }

        [Required, MaxLength(255)]
        public string DiaChiGiaoHang { get; set; }

        public NguoiDung NguoiDung { get; set; }
        public TrangThaiDonHang TrangThaiDonHang { get; set; }

        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }


}
