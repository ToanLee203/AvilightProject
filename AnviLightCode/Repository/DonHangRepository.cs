using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class DonHangRepository : IDonHangRepository
    {
        private readonly AnvilightDbContext _context;
        public DonHangRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<DonHang>> GetAllAsync()
        {
            return _context.Set<DonHang>().ToList();
        }

        public async Task<DonHang> GetByIdAsync(int id)
        {
            return await _context.Set<DonHang>().FindAsync(id);
        }

        public async Task AddAsync(DonHang obj)
        {
            await _context.Set<DonHang>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DonHang obj)
        {
            _context.Set<DonHang>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<DonHang>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
