using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagnificoPonto.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IAmigurumiRepository _amigurumiRepository;
        private readonly CarrinhoCompra carrinhoCompra;

        public CarrinhoCompraController(IAmigurumiRepository amigurumiRepository, CarrinhoCompra carrinhoCompra)
        {
            _amigurumiRepository = amigurumiRepository;
            this.carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
