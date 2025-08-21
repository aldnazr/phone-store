
namespace PhoneStore.Data.Services
{
    public interface ICrudService<T>
    {
        Task<List<T>> GetAllAsync(string endpoint);
        Task<bool> InsertAsync(string endpoint, T entity);
        Task<bool> UpdateAsync(string endpoint, int? id, T entity);
        Task<bool> DeleteAsync(string endpoint, int? id);
    }
}