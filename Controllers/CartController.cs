using BookStore2024.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStore2024.Controllers
{
    public class CartController : Controller
    {
        private readonly BookStoreContext DBContext;
        public CartController(BookStoreContext DatabaseContext) => DBContext = DatabaseContext;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddtoCart(int productDetailId)
        {
            return View();
        }
    }
}
