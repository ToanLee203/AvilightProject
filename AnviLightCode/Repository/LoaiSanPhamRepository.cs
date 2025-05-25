using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class LoaiSanPhamRepository : ILoaiSanPhamRepository
    {
        private readonly AnvilightDbContext _context;
        public LoaiSanPhamRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<LoaiSanPham>> GetAllAsync()
        {
            return _context.Set<LoaiSanPham>().ToList();
        }

        public async Task<LoaiSanPham> GetByIdAsync(int id)
        {
            return await _context.Set<LoaiSanPham>().FindAsync(id);
        }

        public async Task AddAsync(LoaiSanPham obj)
        {
            await _context.Set<LoaiSanPham>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LoaiSanPham obj)
        {
            _context.Set<LoaiSanPham>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<LoaiSanPham>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
