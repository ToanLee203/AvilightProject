using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class LoaiSanPhamService : ILoaiSanPhamService
    {
        private readonly ILoaiSanPhamRepository _repository;
        public LoaiSanPhamService(ILoaiSanPhamRepository repository) => _repository = repository;

        public async Task<IEnumerable<LoaiSanPham>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<LoaiSanPham> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(LoaiSanPham obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(LoaiSanPham obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
