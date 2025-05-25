using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ICartRepository
    {
        Task<IEnumerable<Cart>> GetAllAsync();
        Task<Cart> GetByIdAsync(int id);
        Task AddAsync(Cart obj);
        Task UpdateAsync(Cart obj);
        Task DeleteAsync(int id);
    }
}
