using AnviLightCode.IService;
using AnviLightCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnviLightCode.Pages.User
{
    public class HomeModel : PageModel
    {
        private readonly ISanPhamService _sanPhamService;
        private readonly ILoaiSanPhamService _loaiSanPhamService;

        public HomeModel(ISanPhamService sanPhamService , ILoaiSanPhamService loaiSanPhamService)
        {
            _sanPhamService = sanPhamService;
            _loaiSanPhamService = loaiSanPhamService;
        }
        public List<SanPham> DanhSachDenNoiBat { get; set; }
        public List<SanPham> DanhSachDenBanChayNhat { get; set; }
        public List<LoaiSanPham> DanhSachLoaiSanPham { get; set; }
        public List<SanPham> DanhSachSanPham { get; set; }
        


        public async Task OnGetAsync()
        {
            DanhSachDenNoiBat = (await _sanPhamService.GetAllAsync())
                              .OrderBy(sp => sp.SoLuongTon)
                              .Take(4)
                              .ToList();
            DanhSachDenBanChayNhat = (await _sanPhamService.GetAllAsync())
                              .OrderBy(sp => sp.SoLuongBanRa)
                              .Take(1)
                              .ToList();
            DanhSachLoaiSanPham = (await _loaiSanPhamService.GetAllAsync()).Where(x=>x.KieuSanPham != 0).ToList();
            DanhSachSanPham = (await _sanPhamService.GetAllAsync()).ToList();
        }
    }
}
