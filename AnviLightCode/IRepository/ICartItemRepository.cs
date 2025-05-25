using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface ICartItemRepository
    {
        Task<IEnumerable<CartItem>> GetAllAsync();
        Task<CartItem> GetByIdAsync(int id);
        Task AddAsync(CartItem obj);
        Task UpdateAsync(CartItem obj);
        Task DeleteAsync(int id);
    }
}
