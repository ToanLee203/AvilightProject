using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IChiTietDonHangService
    {
        Task<IEnumerable<ChiTietDonHang>> GetAllAsync();
        Task<ChiTietDonHang> GetByIdAsync(int id);
        Task AddAsync(ChiTietDonHang obj);
        Task UpdateAsync(ChiTietDonHang obj);
        Task DeleteAsync(int id);
    }
}
