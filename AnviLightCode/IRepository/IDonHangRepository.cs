using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IDonHangRepository
    {
        Task<IEnumerable<DonHang>> GetAllAsync();
        Task<DonHang> GetByIdAsync(int id);
        Task AddAsync(DonHang obj);
        Task UpdateAsync(DonHang obj);
        Task DeleteAsync(int id);
    }
}
