using BookStore2024.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookStore2024.ViewModels
{
	public class CategoriesMenuVM
	{
		//private readonly BookStoreContext DBContext;

		public int CategoryId { get; set; }

		public string CategoryName { get; set; }

		public int Quantity {  get; set; }

		//public CategoriesMenuVM(BookStoreContext db,int cate_id, string cate_name) 
		//{  
		//	DBContext = db; 
		//	CategoryId = cate_id;
		//	CategoryName = cate_name;
		//	Quantity = db.ViewBookDetails.Where(bd =>  bd.CategoryId == CategoryId).Count();

		//}
	}
}
