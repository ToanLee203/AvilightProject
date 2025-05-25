using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IBienTheSanPhamRepository
    {
        Task<IEnumerable<BienTheSanPham>> GetAllAsync();
        Task<BienTheSanPham> GetByIdAsync(int id);
        Task AddAsync(BienTheSanPham obj);
        Task UpdateAsync(BienTheSanPham obj);
        Task DeleteAsync(int id);
    }
}
