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
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Ürün Açıklaması Minimum 20 Karakter ve Maksimum 100 Karakter Olmalıdır")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat Belirtiniz")]
        [Range(1, 10000)]
        public decimal Price { get; set; }


        public List<Category> SelectedCategories { get; set; }


    }
}
