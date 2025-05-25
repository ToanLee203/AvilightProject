using AnviLightCode.Models;

namespace AnviLightCode.IRepository
{
    public interface IMauSacRepository
    {
        Task<IEnumerable<MauSac>> GetAllAsync();
        Task<MauSac> GetByIdAsync(int id);
        Task AddAsync(MauSac obj);
        Task UpdateAsync(MauSac obj);
        Task DeleteAsync(int id);
    }
}
