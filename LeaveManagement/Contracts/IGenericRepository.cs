using LeaveManagement.Data;

namespace LeaveManagement.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetAsync(int Id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int Id);
        Task DeleteAsync(int Id);
        Task<T> UpdateAsync(T entity);

    }
}
