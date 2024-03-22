using BookStore2024.Data;
using BookStore2024.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore2024.Controllers
{
    public class ProductsController : Controller
    {
		private readonly BookStoreContext DBContext;
		public ProductsController(BookStoreContext DatabaseContext) => DBContext = DatabaseContext;
		public IActionResult Index(int? category)
        {
            var ProductsQuery = DBContext.ViewBookDetails.AsQueryable();

            if(category.HasValue)
            {
				ProductsQuery = ProductsQuery.Where(p => p.CategoryId == category.Value);

			}

            var data = ProductsQuery.Select(p => new ProductVM
            {
				CategoryId = p.CategoryId,
				CategoryName = p.CategoryName,
				ProductName = p.BookTitle,
				ProductImg = p.BookImageUrl ?? "",
				AuthorName = p.AuthorName,
				Price = p.Price,
				Discount = p.Discount
			});

            return View(data);
        }
    }
}
