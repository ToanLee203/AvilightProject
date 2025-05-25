using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class TrangThaiDonHangService : ITrangThaiDonHangService
    {
        private readonly ITrangThaiDonHangRepository _repository;
        public TrangThaiDonHangService(ITrangThaiDonHangRepository repository) => _repository = repository;

        public async Task<IEnumerable<TrangThaiDonHang>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<TrangThaiDonHang> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(TrangThaiDonHang obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(TrangThaiDonHang obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
