using Microsoft.AspNetCore.Mvc;

namespace BookStore2024.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(int? category)
        {
            return View();
        }
    }
}
