using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class DonHangService : IDonHangService
    {
        private readonly IDonHangRepository _repository;
        public DonHangService(IDonHangRepository repository) => _repository = repository;

        public async Task<IEnumerable<DonHang>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<DonHang> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(DonHang obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(DonHang obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
