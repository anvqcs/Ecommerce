using Ecommerce.Models.ViewModel.Product;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository) 
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var model = _repository.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
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
        [HttpGet]
        public async Task<IActionResult> Update(int ProductId)
        {
            var product = await _repository.GetByIdAsync(ProductId);
            if (product == null) 
            {
                var model = new ProductViewModel()
                {
                    ProductId = ProductId,
                    Name = product.Name,
                    Description = product.Description,

                };
            }
            return View();
        }
    }
}
