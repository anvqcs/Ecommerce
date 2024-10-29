using Ecommerce.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        private readonly EcommerceContext _context;
        public OrderController(EcommerceContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var model = await _context.Orders.ToListAsync();
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int OrderId)
        {
            var model = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == OrderId);
            if (model == null) 
            {
                return NotFound();
            }
            return View();
        }
    }
}
