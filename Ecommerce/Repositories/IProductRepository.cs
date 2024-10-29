using Ecommerce.Models.Entities;
using Ecommerce.Models.ViewModel.Product;

namespace Ecommerce.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(ProductViewModel product);
        Task UpdateAsync(ProductViewModel product);
        Task DeleteAsync(int id);
    }
}
