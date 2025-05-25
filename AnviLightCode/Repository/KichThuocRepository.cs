using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class KichThuocRepository : IKichThuocRepository
    {
        private readonly AnvilightDbContext _context;
        public KichThuocRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<KichThuoc>> GetAllAsync()
        {
            return _context.Set<KichThuoc>().ToList();
        }

        public async Task<KichThuoc> GetByIdAsync(int id)
        {
            return await _context.Set<KichThuoc>().FindAsync(id);
        }

        public async Task AddAsync(KichThuoc obj)
        {
            await _context.Set<KichThuoc>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(KichThuoc obj)
        {
            _context.Set<KichThuoc>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<KichThuoc>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
