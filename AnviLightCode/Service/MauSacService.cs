using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class MauSacService : IMauSacService
    {
        private readonly IMauSacRepository _repository;
        public MauSacService(IMauSacRepository repository) => _repository = repository;

        public async Task<IEnumerable<MauSac>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<MauSac> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(MauSac obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(MauSac obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
