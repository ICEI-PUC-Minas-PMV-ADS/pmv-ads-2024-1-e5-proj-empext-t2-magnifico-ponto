/*




using System.Xml.Linq;
using MagnificoPonto.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using static System.Net.WebRequestMethods;
using Stripe.Checkout;
using Stripe.Issuing;

namespace MagnificoPonto.Controllers
{

    public class PaymentController : Controller
    {
        private readonly StripeSettings _stripeSettings;
        public PaymentController(IOptions<StripeSettings> stripeSettings)
        {
            _stripeSettings = stripeSettings.Value;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCheckoutSession(string amount)
        {
            var currency = "brl";
            var successUrl = "https://localhost:7171/Payment/success";
            var cancelUrl = "https://localhost:7171/Payment/cancel";
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
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
                            UnitAmount = Convert.ToInt32(amount) * 100,
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
    }
}

*/