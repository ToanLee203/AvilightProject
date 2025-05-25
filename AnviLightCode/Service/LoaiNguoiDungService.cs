using AnviLightCode.Models;
using AnviLightCode.IRepository;
using AnviLightCode.IService;

namespace AnviLightCode.Service
{
    public class LoaiNguoiDungService : ILoaiNguoiDungService
    {
        private readonly ILoaiNguoiDungRepository _repository;
        public LoaiNguoiDungService(ILoaiNguoiDungRepository repository) => _repository = repository;

        public async Task<IEnumerable<LoaiNguoiDung>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<LoaiNguoiDung> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(LoaiNguoiDung obj) => await _repository.AddAsync(obj);
        public async Task UpdateAsync(LoaiNguoiDung obj) => await _repository.UpdateAsync(obj);
        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
