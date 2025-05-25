using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class ChiTietDonHangRepository : IChiTietDonHangRepository
    {
        private readonly AnvilightDbContext _context;
        public ChiTietDonHangRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<ChiTietDonHang>> GetAllAsync()
        {
            return _context.Set<ChiTietDonHang>().ToList();
        }

        public async Task<ChiTietDonHang> GetByIdAsync(int id)
        {
            return await _context.Set<ChiTietDonHang>().FindAsync(id);
        }

        public async Task AddAsync(ChiTietDonHang obj)
        {
            await _context.Set<ChiTietDonHang>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ChiTietDonHang obj)
        {
            _context.Set<ChiTietDonHang>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<ChiTietDonHang>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
