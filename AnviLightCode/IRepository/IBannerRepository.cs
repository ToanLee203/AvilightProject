using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IBannerRepository
    {
        Task<IEnumerable<Banner>> GetAllAsync();
        Task<Banner> GetByIdAsync(int id);
        Task AddAsync(Banner obj);
        Task UpdateAsync(Banner obj);
        Task DeleteAsync(int id);
    }
}
