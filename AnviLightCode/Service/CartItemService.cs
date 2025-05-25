using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;
using Microsoft.EntityFrameworkCore;

namespace AnviLightCode.Service
{
    public class CartItemService : ICartItemService
    {

        private readonly ICartItemRepository _repository;
        public CartItemService(ICartItemRepository repository) => _repository = repository;

        public async Task<IEnumerable<CartItem>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<CartItem> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(CartItem obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(CartItem obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
        public async Task<List<CartItem>> GetByCartIdWithDetailsAsync(int cartId)
        {
            return await _repository.GetByCartIdWithDetailsAsync(cartId);
        }

    }
}
