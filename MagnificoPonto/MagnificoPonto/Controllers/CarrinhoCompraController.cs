using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;
using MagnificoPonto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagnificoPonto.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IAmigurumiRepository _amigurumiRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IAmigurumiRepository amigurumiRepository, CarrinhoCompra carrinhoCompra)
        {
            _amigurumiRepository = amigurumiRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        public IActionResult AdicionarItemNoCarrinhoCompra (int amigurumiId)
        {
            var amigurumiSelecionado = _amigurumiRepository.Amigurumis
                                       .FirstOrDefault(p=> p.AmigurumiId == amigurumiId);

            if (amigurumiSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(amigurumiSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemNoCarrinhoCompra(int amigurumiId)
        {
            var amigurumiSelecionado = _amigurumiRepository.Amigurumis
                                       .FirstOrDefault(p => p.AmigurumiId == amigurumiId);

            if (amigurumiSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(amigurumiSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
