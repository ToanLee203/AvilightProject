using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IDonHangService
    {
        Task<IEnumerable<DonHang>> GetAllAsync();
        Task<DonHang> GetByIdAsync(int id);
        Task AddAsync(DonHang obj);
        Task UpdateAsync(DonHang obj);
        Task DeleteAsync(int id);
    }
}
