using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepository _repository;
        public SanPhamService(ISanPhamRepository repository) => _repository = repository;

        public async Task<IEnumerable<SanPham>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<SanPham> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(SanPham obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(SanPham obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
