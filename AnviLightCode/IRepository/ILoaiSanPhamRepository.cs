using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ILoaiSanPhamRepository
    {
        Task<IEnumerable<LoaiSanPham>> GetAllAsync();
        Task<LoaiSanPham> GetByIdAsync(int id);
        Task AddAsync(LoaiSanPham obj);
        Task UpdateAsync(LoaiSanPham obj);
        Task DeleteAsync(int id);
    }
}
