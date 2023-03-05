using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

 
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Ürün açıklaması minimum 20 karakter ve maksimum 100 karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat belirtiniz")]
        [Range(1, 10000)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
