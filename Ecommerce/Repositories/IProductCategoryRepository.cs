using Ecommerce.Models.Entities;
using Ecommerce.Models.ViewModel.ProductCategory;

namespace Ecommerce.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCategory>> GetAllAsync();
        Task<ProductCategory> GetByIdAsync(int id);
        Task AddProductCategoryAsync(ProductCategoryViewModel model);
        Task DeleteProductCategoryAsync(int id);
        Task UpdateProductCategoryAsync(ProductCategoryViewModel model);
    }
}
