
namespace MagnificoPonto.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public ProdutoModel Product { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }

    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
