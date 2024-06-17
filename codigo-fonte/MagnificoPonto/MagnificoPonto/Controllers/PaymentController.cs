




using System.Xml.Linq;
using MagnificoPonto.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using static System.Net.WebRequestMethods;
using Stripe.Checkout;
using Stripe.Issuing;
using Microsoft.EntityFrameworkCore;
using MagnificoPonto.Data;

namespace MagnificoPonto.Controllers
{

    public class PaymentController : Controller
    {
        private readonly StripeSettings _stripeSettings;
        private readonly ApplicationDbContext _context;
        public PaymentController(IOptions<StripeSettings> stripeSettings, ApplicationDbContext context)
        {
            _stripeSettings = stripeSettings.Value;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCheckoutSession(string amount, int shoppingCartId)
        {
            var currency = "brl";
            var successUrl = $"https://localhost:7171/Payment/Success?shoppingCartId={shoppingCartId}";
            var cancelUrl = $"https://localhost:7171/Payment/Cancel?shoppingCartId={shoppingCartId}";
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            amount = amount.Replace(",", "");
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = currency,
                            UnitAmount = Convert.ToInt32(amount),
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Product Name",
                                Description = "Product Description"
                            },
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl
            };

            var service = new SessionService();
            var session = service.Create(options);

            return Redirect(session.Url);
        }
        public async Task<IActionResult> Success(int shoppingCartId) 
        {
            var shoppingCart = await _context.ShoppingCarts
                .Include(s => s.CartItems)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(s => s.ShoppingCartId == shoppingCartId);

            return View(shoppingCart); 
        }
    }
}

