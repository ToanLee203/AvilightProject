using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class ChiTietDonHangService : IChiTietDonHangService
    {
        private readonly IChiTietDonHangRepository _repository;
        public ChiTietDonHangService(IChiTietDonHangRepository repository) => _repository = repository;

        public async Task<IEnumerable<ChiTietDonHang>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<ChiTietDonHang> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(ChiTietDonHang obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(ChiTietDonHang obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
