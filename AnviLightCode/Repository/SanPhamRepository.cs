using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly AnvilightDbContext _context;
        public SanPhamRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<SanPham>> GetAllAsync()
        {
            return _context.Set<SanPham>().ToList();
        }

        public async Task<SanPham> GetByIdAsync(int id)
        {
            return await _context.Set<SanPham>().FindAsync(id);
        }

        public async Task AddAsync(SanPham obj)
        {
            await _context.Set<SanPham>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SanPham obj)
        {
            _context.Set<SanPham>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<SanPham>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
