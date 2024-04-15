using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;
using MagnificoPonto.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MagnificoPonto.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAmigurumiRepository _amigurumiRepository;

        public HomeController(IAmigurumiRepository amigurumiRepository)
        {
            _amigurumiRepository = amigurumiRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AmigurumisLancamento = _amigurumiRepository.AmigurumiLancamento
            };

            return View(homeViewModel);
        }

        public IActionResult TermosdeUso()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}