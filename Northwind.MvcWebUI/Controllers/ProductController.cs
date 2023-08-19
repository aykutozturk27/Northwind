using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productList = _productService.GetAll();
            return View(productList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductAddDto productAddDto)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    ProductName = productAddDto.ProductName,
                    UnitPrice = productAddDto.UnitPrice,
                    QuantityPerUnit = productAddDto.QuantityPerUnit,
                    UnitsInStock = productAddDto.UnitsInStock,
                    Category = productAddDto.Category,
                    CategoryID = productAddDto.CategoryID
                };

                var addedProduct = _productService.Add(product);
                if (addedProduct != null)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            return View(productAddDto);
        }
    }
}
