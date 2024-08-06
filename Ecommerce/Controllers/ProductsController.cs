using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
