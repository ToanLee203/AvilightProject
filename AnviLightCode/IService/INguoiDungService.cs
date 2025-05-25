using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface INguoiDungService
    {
        Task<IEnumerable<NguoiDung>> GetAllAsync();
        Task<NguoiDung> GetByIdAsync(int id);
        Task AddAsync(NguoiDung obj);
        Task UpdateAsync(NguoiDung obj);
        Task DeleteAsync(int id);
    }
}
