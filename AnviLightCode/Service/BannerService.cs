using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _repository;
        public BannerService(IBannerRepository repository) => _repository = repository;

        public async Task<IEnumerable<Banner>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<Banner> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(Banner obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(Banner obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
