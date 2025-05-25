using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ILoaiNguoiDungRepository
    {
        Task<IEnumerable<LoaiNguoiDung>> GetAllAsync();
        Task<LoaiNguoiDung> GetByIdAsync(int id);
        Task AddAsync(LoaiNguoiDung obj);
        Task UpdateAsync(LoaiNguoiDung obj);
        Task DeleteAsync(int id);
    }
}
