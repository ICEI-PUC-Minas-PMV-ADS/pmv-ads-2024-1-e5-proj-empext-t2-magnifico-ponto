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
        public async Task<IActionResult> Index()
        {
            var shoppingCartId = HttpContext.Session.GetInt32("ShoppingCartId");

            if (shoppingCartId == null)
            {
                return NotFound();
            }

            var shoppingCart = await _context.ShoppingCarts
                .Include(s => s.CartItems)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(s => s.ShoppingCartId == shoppingCartId);

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
            var shoppingCartId = HttpContext.Session.GetInt32("ShoppingCartId");
            
            var product = await _context.Produtos.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var cartItem = new CartItem { Product = product, Quantity = 1 };
            ShoppingCart shoppingCart;
            if (shoppingCartId == null) 
            { 
                shoppingCart = new ShoppingCart(); 
                shoppingCart.CartItems = new List<CartItem>
                    {
                        cartItem
                    };
                _context.Add(shoppingCart);
            }
            else
            {
                shoppingCart = await _context.ShoppingCarts
                .Include(s => s.CartItems)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(s => s.ShoppingCartId == shoppingCartId);

                cartItem.ShoppingCart = shoppingCart;
                _context.Add(cartItem);
            }

            
            await _context.SaveChangesAsync();

            HttpContext.Session.SetInt32("ShoppingCartId", shoppingCart.ShoppingCartId);

            return RedirectToAction("Index");
        }
    }
}
