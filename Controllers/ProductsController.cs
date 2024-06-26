﻿using BookStore2024.Data;
using BookStore2024.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

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
				Discount = p.Discount,
                FormatName = p.FormatName,
                BookDetailId = p.BookDetailId
            });

            return View(data);
        }
        public IActionResult Search(String? searchString)
        {
            var ProductsQuery = DBContext.ViewBookDetails.AsQueryable();
            if (searchString != null) {
                ProductsQuery = ProductsQuery.Where(p => p.BookTitle.Contains(searchString));
            }
            var data = ProductsQuery.Select(p => new ProductVM
            {
                BookDetailId = p.BookDetailId,
                CategoryId = p.CategoryId,
                CategoryName = p.CategoryName,
                ProductName = p.BookTitle,
                ProductImg = p.BookImageUrl ?? "",
                AuthorName = p.AuthorName,
                Price = p.Price,
                Discount = p.Discount,
                FormatName = p.FormatName
            });

            return View(data);
        }

        public IActionResult Detail(int DetailId)
        {
            var record = DBContext.ViewBookDetails.Where(p => p.BookDetailId == DetailId).SingleOrDefault();
            if (record == null)
            {
                TempData["Message"] = $"Could not find product have id: {DetailId} or product does not exist";
                return Redirect("/404");
            }
            var data = new ProductVM
            {   
                BookDetailId = record.BookDetailId,
                CategoryId = record.CategoryId,
                CategoryName = record.CategoryName,
                ProductName = record.BookTitle,
                ProductImg = record.BookImageUrl ?? "",
                AuthorName = record.AuthorName,
                Price = record.Price,
                Discount = record.Discount,
                FormatId = record.FormatId,
                FormatName = record.FormatName,
                GenreName = record.GenreName,
                GenreId = record.GenreId,
                Publisher = record.Publisher,
                ProductDescription = record.BookDescription,
                Language = record.Language,
                Pages = record.Pages,
                IllustrationsNote = record.IllustrationsNote,
                Isbn10 = record.Isbn10,
                Isbn13 = record.Isbn13,
                StockQuantity = record.StockQuantity,
                Views = record.Views
            };

            return View(data);
        }
    }
}
