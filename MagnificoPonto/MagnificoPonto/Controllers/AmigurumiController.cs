using MagnificoPonto.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagnificoPonto.Controllers
{
    public class AmigurumiController : Controller
    {
        private readonly IAmigurumiRepository _amigurumiRepository;

        public AmigurumiController(IAmigurumiRepository amigurumiRepository)
        {
            _amigurumiRepository = amigurumiRepository;
        }

        public IActionResult List()
        {
            var amigurumis = _amigurumiRepository.Amigurumis;
            
            return View(amigurumis);
        }
    }
}
