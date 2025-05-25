using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AnvilightDbContext _context;
        public CartItemRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<CartItem>> GetAllAsync()
        {
            return _context.Set<CartItem>().ToList();
        }

        public async Task<CartItem> GetByIdAsync(int id)
        {
            return await _context.Set<CartItem>().FindAsync(id);
        }

        public async Task AddAsync(CartItem obj)
        {
            await _context.Set<CartItem>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CartItem obj)
        {
            _context.Set<CartItem>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<CartItem>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
