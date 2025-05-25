using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IBannerService
    {
        Task<IEnumerable<Banner>> GetAllAsync();
        Task<Banner> GetByIdAsync(int id);
        Task AddAsync(Banner obj);
        Task UpdateAsync(Banner obj);
        Task DeleteAsync(int id);
    }
}
