using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IKichThuocRepository
    {
        Task<IEnumerable<KichThuoc>> GetAllAsync();
        Task<KichThuoc> GetByIdAsync(int id);
        Task AddAsync(KichThuoc obj);
        Task UpdateAsync(KichThuoc obj);
        Task DeleteAsync(int id);
    }
}
