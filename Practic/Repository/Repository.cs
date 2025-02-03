using Microsoft.EntityFrameworkCore;
using Practic.Infra;
using Practic.Model;

namespace Practic.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task AddAsync(T product)
        {
            _context.Set<T>().Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await GetByIdAsync(id);
            if (product != null)
            {
                _context.Set<T>().Remove(product);
                await _context.SaveChangesAsync();
            }            
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetProducts()
        {
          return _context.Set<T>().AsQueryable();
        }
    }
}
