using Practic.Model;

namespace Practic.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
