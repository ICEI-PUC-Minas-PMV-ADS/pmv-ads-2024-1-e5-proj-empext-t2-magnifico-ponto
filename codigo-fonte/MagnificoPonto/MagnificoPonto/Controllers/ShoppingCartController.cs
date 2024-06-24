using MagnificoPonto.Data;
using MagnificoPonto.Models;
using MagnificoPonto.Services.Models;
using MagnificoPonto.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

            if (HttpContext.Session.GetInt32("FormularioEntregaId") != null){
                var formularioEntrega = await _context.FormularioEntregas.FirstOrDefaultAsync(s => s.Id == HttpContext.Session.GetInt32("FormularioEntregaId"));
                List<int> productIds = shoppingCart.CartItems.Select(c => c.Product.Id).ToList();

                List<ProdutoModel> models = await _context.Produtos
                    .Where(m => productIds.Contains(m.Id))
                    .ToListAsync();

                if (!models.Any())
                {
                    NotFound();
                }

                var result = await MelhorEnvioService.GetApiResponse(models, formularioEntrega.Cep.ToString());
                List<MelhorEnvioResponse> rootList = JsonConvert.DeserializeObject<List<MelhorEnvioResponse>>(result.Content);
                List<Dictionary<string, string>> keyValuePairs = new List<Dictionary<string, string>>();
                foreach (var item in rootList)
                {
                    var dict = new Dictionary<string, string>
                    {
                        { "Serviço", item.name },
                        { "Preço", item.price != null ? item.price : "" }
                    };
                    keyValuePairs.Add(dict);
                }

                ViewBag.Result = keyValuePairs;
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
        [HttpPost]
        public async Task<IActionResult> Delete(int cartItemId)
        {
            var shoppingCartId = HttpContext.Session.GetInt32("ShoppingCartId");

            var shoppingCart = await _context.ShoppingCarts.Include(s => s.CartItems).FirstOrDefaultAsync(s => s.ShoppingCartId == shoppingCartId);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            var cartItem = shoppingCart.CartItems.Find(s => s.CartItemId == cartItemId);

            shoppingCart.CartItems.Remove(cartItem);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
