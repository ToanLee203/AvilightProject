using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;
        public CartService(ICartRepository repository) => _repository = repository;

        public async Task<IEnumerable<Cart>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<Cart> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(Cart obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(Cart obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
