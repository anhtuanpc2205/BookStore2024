namespace BookStore2024.ViewModels
{
    public class CartItem
    {
        public int BookDetailId { get; set; }
        public string? ProductName { get; set; } = null;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Amount => Price * Quantity;
    }
}
