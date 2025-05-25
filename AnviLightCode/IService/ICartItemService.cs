using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface ICartItemService
    {
        Task<IEnumerable<CartItem>> GetAllAsync();
        Task<CartItem> GetByIdAsync(int id);
        Task AddAsync(CartItem obj);
        Task UpdateAsync(CartItem obj);
        Task DeleteAsync(int id);
    }
}
