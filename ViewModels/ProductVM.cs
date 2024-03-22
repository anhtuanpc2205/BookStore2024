namespace BookStore2024.ViewModels
{
	public class ProductVM
	{
		public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? ProductName { get; set; }
		public string? ProductImg { get; set; }
		public string? AuthorName { get; set; }
		public decimal Price { get; set; }
		public decimal? Discount { get; set; } = 0;
	}
}
