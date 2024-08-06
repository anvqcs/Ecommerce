using Ecommerce.Data;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ViewComponents
{
    [ViewComponent(Name = "MenuProductCategory")]
    public class MenuProductCategoryViewComponent: ViewComponent 
    {
        private readonly EcommerceContext _context;

        public MenuProductCategoryViewComponent(EcommerceContext context) 
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var item = _context.ProductCategories.Select(item => new MenuProductCategoryVM
            {
                Id =  item.ProductCategoryId, Name = item.Title, Count = item.Products.Count
            });
            return View(item);
        }
    }
}
