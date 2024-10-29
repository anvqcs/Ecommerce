using Ecommerce.Models.Entities;
using Ecommerce.Models.ViewModel.ProductCategory;

namespace Ecommerce.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCategory>> GetAllAsync();
        Task<ProductCategory> GetByIdAsync(int id);
        Task AddAsync(ProductCategoryViewModel model);
        Task UpdateAsync(ProductCategoryViewModel model);
        Task DeleteAsync(int id);
    }
}
