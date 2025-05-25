using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class TrangThaiDonHangRepository : ITrangThaiDonHangRepository
    {
        private readonly AnvilightDbContext _context;
        public TrangThaiDonHangRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<TrangThaiDonHang>> GetAllAsync()
        {
            return _context.Set<TrangThaiDonHang>().ToList();
        }

        public async Task<TrangThaiDonHang> GetByIdAsync(int id)
        {
            return await _context.Set<TrangThaiDonHang>().FindAsync(id);
        }

        public async Task AddAsync(TrangThaiDonHang obj)
        {
            await _context.Set<TrangThaiDonHang>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TrangThaiDonHang obj)
        {
            _context.Set<TrangThaiDonHang>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<TrangThaiDonHang>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
