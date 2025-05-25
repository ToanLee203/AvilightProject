using AnviLightCode.Models;

namespace AnviLightCode.IService
{
    public interface IMauSacService
    {
        Task<IEnumerable<MauSac>> GetAllAsync();
        Task<MauSac> GetByIdAsync(int id);
        Task AddAsync(MauSac obj);
        Task UpdateAsync(MauSac obj);
        Task DeleteAsync(int id);
    }
}
