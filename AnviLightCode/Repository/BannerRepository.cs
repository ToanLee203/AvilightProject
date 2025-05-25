using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class BannerRepository : IBannerRepository
    {
        private readonly AnvilightDbContext _context;
        public BannerRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<Banner>> GetAllAsync()
        {
            return _context.Set<Banner>().ToList();
        }

        public async Task<Banner> GetByIdAsync(int id)
        {
            return await _context.Set<Banner>().FindAsync(id);
        }

        public async Task AddAsync(Banner obj)
        {
            await _context.Set<Banner>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Banner obj)
        {
            _context.Set<Banner>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<Banner>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
