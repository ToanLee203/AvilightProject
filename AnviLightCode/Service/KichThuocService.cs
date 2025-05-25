using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class KichThuocService : IKichThuocService
    {
        private readonly IKichThuocRepository _repository;
        public KichThuocService(IKichThuocRepository repository) => _repository = repository;

        public async Task<IEnumerable<KichThuoc>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<KichThuoc> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(KichThuoc obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(KichThuoc obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
