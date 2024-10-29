using Ecommerce.Models.Entities;
using Ecommerce.Models.ViewModel.Product;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        private readonly IProductCategoryRepository _categoryRepository;

        public ProductController(IProductRepository repository, IProductCategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var model = await _repository.GetAllAsync();
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryRepository.GetAllAsync();
            var model = new ProductViewModel
            {
                Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.ProductCategoryId.ToString(),
                    Text = c.Name
                })
            };
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int ProductId)
        {
            var product = await _repository.GetByIdAsync(ProductId);
            var categories = await _categoryRepository.GetAllAsync();
            if (product == null)
            {
                return NotFound();
            }
            var model = new ProductViewModel()
            {
                ProductId = ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ProductCategoryId = product.ProductCategoryId,
                Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.ProductCategoryId.ToString(),
                    Text = c.Name
                })
            };
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Delete(int ProductId)
        {
            await _repository.DeleteAsync(ProductId);
            return RedirectToAction(nameof(Index));
        }
    }
}
