using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class MauSacRepository : IMauSacRepository
    {
        private readonly AnvilightDbContext _context;
        public MauSacRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<MauSac>> GetAllAsync()
        {
            return _context.Set<MauSac>().ToList();
        }

        public async Task<MauSac> GetByIdAsync(int id)
        {
            return await _context.Set<MauSac>().FindAsync(id);
        }

        public async Task AddAsync(MauSac obj)
        {
            await _context.Set<MauSac>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MauSac obj)
        {
            _context.Set<MauSac>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<MauSac>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
