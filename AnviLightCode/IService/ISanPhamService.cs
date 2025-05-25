using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface ISanPhamService
    {
        Task<IEnumerable<SanPham>> GetAllAsync();
        Task<SanPham> GetByIdAsync(int id);
        Task AddAsync(SanPham obj);
        Task UpdateAsync(SanPham obj);
        Task DeleteAsync(int id);
    }
}
