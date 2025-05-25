using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class BienTheSanPhamRepository : IBienTheSanPhamRepository
    {
        private readonly AnvilightDbContext _context;
        public BienTheSanPhamRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<BienTheSanPham>> GetAllAsync()
        {
            return _context.Set<BienTheSanPham>().ToList();
        }

        public async Task<BienTheSanPham> GetByIdAsync(int id)
        {
            return await _context.Set<BienTheSanPham>().FindAsync(id);
        }

        public async Task AddAsync(BienTheSanPham obj)
        {
            await _context.Set<BienTheSanPham>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BienTheSanPham obj)
        {
            _context.Set<BienTheSanPham>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<BienTheSanPham>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
