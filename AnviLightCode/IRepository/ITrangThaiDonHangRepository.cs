using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ITrangThaiDonHangRepository
    {
        Task<IEnumerable<TrangThaiDonHang>> GetAllAsync();
        Task<TrangThaiDonHang> GetByIdAsync(int id);
        Task AddAsync(TrangThaiDonHang obj);
        Task UpdateAsync(TrangThaiDonHang obj);
        Task DeleteAsync(int id);
    }
}
