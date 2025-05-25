using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        private readonly AnvilightDbContext _context;
        public NguoiDungRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<NguoiDung>> GetAllAsync()
        {
            return _context.Set<NguoiDung>().ToList();
        }

        public async Task<NguoiDung> GetByIdAsync(int id)
        {
            return await _context.Set<NguoiDung>().FindAsync(id);
        }

        public async Task AddAsync(NguoiDung obj)
        {
            await _context.Set<NguoiDung>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(NguoiDung obj)
        {
            _context.Set<NguoiDung>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<NguoiDung>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
