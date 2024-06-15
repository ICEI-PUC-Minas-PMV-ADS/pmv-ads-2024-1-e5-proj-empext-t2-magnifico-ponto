using MagnificoPonto.Data;
using MagnificoPonto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MagnificoPonto.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listarProdutos = await _context.Produtos.ToListAsync();
            return View(listarProdutos);
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }

        public IActionResult Termos()
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
