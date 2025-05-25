using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repository;
        public BlogService(IBlogRepository repository) => _repository = repository;

        public async Task<IEnumerable<Blog>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<Blog> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(Blog obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(Blog obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
