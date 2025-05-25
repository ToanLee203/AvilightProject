using AnviLightCode.IService;
using AnviLightCode.ModelDTO;
using AnviLightCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AnviLightCode.Pages.User
{
    public class ProductDetailModel : PageModel
    {
        private readonly ISanPhamService _sanPhamService;
        private readonly ILoaiSanPhamService _loaiSanPhamService;
        private readonly IBienTheSanPhamService _bienTheSanPhamService;
        private readonly IKichThuocService _kichThuocService;
        private readonly IMauSacService _mauSacService;


        public ProductDetailModel(
            ISanPhamService sanPhamService,
            ILoaiSanPhamService loaiSanPhamService,
            IBienTheSanPhamService bienTheSanPhamService,
            IKichThuocService kichThuocService,
            IMauSacService mauSacService)
        {
            _sanPhamService = sanPhamService;
            _loaiSanPhamService = loaiSanPhamService;
            _bienTheSanPhamService = bienTheSanPhamService;
            _kichThuocService = kichThuocService;
            _mauSacService = mauSacService;
        }

        public SanPham Product { get; set; }
        public List<SanPham> RelatedProducts { get; set; }
        public List<BienTheSanPham> BienThes { get; set; }
        public string BienThesJson { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Lấy sản phẩm theo MaSanPham
            Product = await _sanPhamService.GetByIdAsync(id.Value);

            if (Product == null)
            {
                return NotFound();
            }

            // Lấy sản phẩm liên quan (cùng danh mục, ngoại trừ sản phẩm hiện tại)
            //RelatedProducts = await _sanPhamService.GetRelatedProductsAsync(Product.MaLoaiSanPham, Product.MaSanPham, 4);
            // Xử lý Size 
            var kichThuocs = await _kichThuocService.GetAllAsync(); // trả về List<KichThuoc>
            var mauSacs = await _mauSacService.GetAllAsync();

            BienThes = (await _bienTheSanPhamService.GetAllAsync())
                .Where(x => x.MaSanPham == id.Value)
                .ToList();

            // Join sang DTO
            var bienTheDTOs = BienThes.Select(x => new BienTheSanPhamDTO
            {
                MaBienTheSanPham = x.MaBienTheSanPham,
                MaKichThuoc = x.MaKichThuoc,
                TenKichThuoc = kichThuocs.FirstOrDefault(k => k.MaKichThuoc == x.MaKichThuoc)?.TenKichThuoc,
                MaMauSac = x.MaMauSac,
                TenMauSac = mauSacs.FirstOrDefault(m => m.MaMauSac == x.MaMauSac)?.TenMauSac
            }).ToList();

            // Serialize JSON
            BienThesJson = JsonSerializer.Serialize(bienTheDTOs);



            return Page();
        }
    }
}