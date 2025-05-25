using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface ILoaiNguoiDungService
    {
        Task<IEnumerable<LoaiNguoiDung>> GetAllAsync();
        Task<LoaiNguoiDung> GetByIdAsync(int id);
        Task AddAsync(LoaiNguoiDung obj);
        Task UpdateAsync(LoaiNguoiDung obj);
        Task DeleteAsync(int id);
    }
}
