using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(int id);
        Task AddAsync(Blog obj);
        Task UpdateAsync(Blog obj);
        Task DeleteAsync(int id);
    }
}
