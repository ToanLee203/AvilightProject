using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ISanPhamRepository
    {
        Task<IEnumerable<SanPham>> GetAllAsync();
        Task<SanPham> GetByIdAsync(int id);
        Task AddAsync(SanPham obj);
        Task UpdateAsync(SanPham obj);
        Task DeleteAsync(int id);
    }
}
