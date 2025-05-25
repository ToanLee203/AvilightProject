using AnviLightCode.Models;
using AnviLightCode.IRepository;

namespace AnviLightCode.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AnvilightDbContext _context;
        public BlogRepository(AnvilightDbContext context) => _context = context;

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return _context.Set<Blog>().ToList();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Set<Blog>().FindAsync(id);
        }

        public async Task AddAsync(Blog obj)
        {
            await _context.Set<Blog>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Blog obj)
        {
            _context.Set<Blog>().Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if (obj != null)
            {
                _context.Set<Blog>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
