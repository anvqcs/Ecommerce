using Ecommerce.Data;
using Ecommerce.Models.ViewModel.ProductCategory;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Ecommerce.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryRepository _repository;

        public ProductCategoryController(IProductCategoryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _repository.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ProductCategoryId)
        {
            var productCategory = await _repository.GetByIdAsync(ProductCategoryId);
            var model = new ProductCategoryViewModel()
            {
                ProductCategoryId = productCategory.ProductCategoryId,
                Name = productCategory.Name,
                Description = productCategory.Description,
                Sort = productCategory.Sort
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int ProductCategoryId)
        {
            await _repository.DeleteAsync(ProductCategoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
