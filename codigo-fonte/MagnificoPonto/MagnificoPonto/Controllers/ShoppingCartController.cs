using MagnificoPonto.Data;
using MagnificoPonto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoppingCart
        public async Task<IActionResult> Index(int id)
        {
            var shoppingCart = await _context.ShoppingCarts
                .Include(s => s.CartItems)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(s => s.ShoppingCartId == id);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            return View(shoppingCart);
        }

        // POST: ShoppingCart/AddToCart/5
        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _context.Produtos.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var cartItem = new CartItem { Product = product, Quantity = 1 };
            var shoppingCart = new ShoppingCart();
            if(shoppingCart.CartItems == null)
            shoppingCart.CartItems = new List<CartItem>
            {
                cartItem
            };
            else
                shoppingCart.CartItems.Add(cartItem);

            _context.Add(shoppingCart);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = shoppingCart.ShoppingCartId });
        }
    }
}
