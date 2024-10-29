using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.ViewModel.Product
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ProductCategoryId { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }
    }
}
