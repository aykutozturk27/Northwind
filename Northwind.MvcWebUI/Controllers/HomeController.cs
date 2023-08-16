using Microsoft.AspNetCore.Mvc;

namespace Northwind.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}