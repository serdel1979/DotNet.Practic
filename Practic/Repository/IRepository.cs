using Practic.Model;

namespace Practic.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetProducts();          
        Task<T> GetByIdAsync(int id);         
        Task AddAsync(T product);             
        Task DeleteAsync(int id);
    }
}
