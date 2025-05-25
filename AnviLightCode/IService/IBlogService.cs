using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(int id);
        Task AddAsync(Blog obj);
        Task UpdateAsync(Blog obj);
        Task DeleteAsync(int id);
    }
}
