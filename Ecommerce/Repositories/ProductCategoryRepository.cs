using Ecommerce.Data;
using Ecommerce.Models.Entities;
using Ecommerce.Models.ViewModel.ProductCategory;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly EcommerceContext _context;
        public ProductCategoryRepository(EcommerceContext context) 
        {
            _context = context;
        }
        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory> GetByIdAsync(int id)
        {
            return await _context.ProductCategories!.FindAsync(id);
        }
        public async Task AddAsync(ProductCategoryViewModel model)
        {
            var ProductCategory = new ProductCategory()
            {
                Name = model.Name,
                Description = model.Description,
                Sort = model.Sort,
                Status = 1,
                CreatedDate = DateTime.Now
            };
            _context.ProductCategories.Add(ProductCategory);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ProductCategoryViewModel model)
        {
            var ProductCategory = new ProductCategory()
            {
                ProductCategoryId = model.ProductCategoryId,
                Name = model.Name,
                Description = model.Description,
                Sort = model.Sort,
                Status = 1,
                CreatedDate = DateTime.Now
            };
            _context.ProductCategories.Update(ProductCategory);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var item = await _context.ProductCategories.FirstOrDefaultAsync(x => x.ProductCategoryId == id);
            if (item != null)
            {
                _context.ProductCategories.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
