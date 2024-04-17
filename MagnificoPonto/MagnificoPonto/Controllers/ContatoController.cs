using Microsoft.AspNetCore.Mvc;

namespace MagnificoPonto.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
