using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface ILoaiSanPhamService
    {
        Task<IEnumerable<LoaiSanPham>> GetAllAsync();
        Task<LoaiSanPham> GetByIdAsync(int id);
        Task AddAsync(LoaiSanPham obj);
        Task UpdateAsync(LoaiSanPham obj);
        Task DeleteAsync(int id);
    }
}
