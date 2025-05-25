using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class NguoiDungService : INguoiDungService
    {
        private readonly INguoiDungRepository _repository;
        public NguoiDungService(INguoiDungRepository repository) => _repository = repository;

        public async Task<IEnumerable<NguoiDung>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<NguoiDung> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(NguoiDung obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(NguoiDung obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
