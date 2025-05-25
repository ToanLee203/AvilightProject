using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IBienTheSanPhamService
    {
        Task<IEnumerable<BienTheSanPham>> GetAllAsync();
        Task<BienTheSanPham> GetByIdAsync(int id);
        Task AddAsync(BienTheSanPham obj);
        Task UpdateAsync(BienTheSanPham obj);
        Task DeleteAsync(int id);
    }
}
