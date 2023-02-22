using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        private ICategoryService _categoryService;

        public IViewComponentResult Invoke()
        {
            
            return View(new CategoryListViewModel()
            {
                Categories=_categoryService.GetAll()
            });
        }


    }
}
