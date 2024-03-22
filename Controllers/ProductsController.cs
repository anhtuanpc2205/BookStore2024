using Microsoft.AspNetCore.Mvc;

namespace BookStore2024.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
