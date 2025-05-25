using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class LoaiNguoiDungRepository : ILoaiNguoiDungRepository
    {
        private readonly AnvilightDbContext _context;
        public LoaiNguoiDungRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<LoaiNguoiDung>> GetAllAsync()
        {
            return _context.Set<LoaiNguoiDung>().ToList();
        }

        public async Task<LoaiNguoiDung> GetByIdAsync(int id)
        {
            return await _context.Set<LoaiNguoiDung>().FindAsync(id);
        }

        public async Task AddAsync(LoaiNguoiDung obj)
        {
            await _context.Set<LoaiNguoiDung>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LoaiNguoiDung obj)
        {
            _context.Set<LoaiNguoiDung>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<LoaiNguoiDung>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
