using Ecommerce.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.ViewModel.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public int ProductCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Sort { get; set; }
    }
}
