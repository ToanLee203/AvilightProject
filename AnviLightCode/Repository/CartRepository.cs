using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly AnvilightDbContext _context;
        public CartRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return _context.Set<Cart>().ToList();
        }

        public async Task<Cart> GetByIdAsync(int id)
        {
            return await _context.Set<Cart>().FindAsync(id);
        }

        public async Task AddAsync(Cart obj)
        {
            await _context.Set<Cart>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cart obj)
        {
            _context.Set<Cart>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<Cart>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
