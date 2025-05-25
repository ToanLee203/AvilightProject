using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class BienTheSanPhamService : IBienTheSanPhamService
    {
        private readonly IBienTheSanPhamRepository _repository;
        public BienTheSanPhamService(IBienTheSanPhamRepository repository) => _repository = repository;

        public async Task<IEnumerable<BienTheSanPham>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<BienTheSanPham> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(BienTheSanPham obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(BienTheSanPham obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
