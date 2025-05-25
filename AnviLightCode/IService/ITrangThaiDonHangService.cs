using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface ITrangThaiDonHangService
    {
        Task<IEnumerable<TrangThaiDonHang>> GetAllAsync();
        Task<TrangThaiDonHang> GetByIdAsync(int id);
        Task AddAsync(TrangThaiDonHang obj);
        Task UpdateAsync(TrangThaiDonHang obj);
        Task DeleteAsync(int id);
    }
}
