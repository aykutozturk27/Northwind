using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;

namespace Northwind.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categoryList = _categoryService.GetAll();
            return View(categoryList);
        }
    }
}
