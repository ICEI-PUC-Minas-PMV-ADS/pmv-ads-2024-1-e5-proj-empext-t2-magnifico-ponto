using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;
using MagnificoPonto.ViewModels;
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

        public IActionResult List(string categoria)
        {
            IEnumerable<Amigurumi> amigurumis;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                amigurumis = _amigurumiRepository.Amigurumis.OrderBy(a => a.AmigurumiId);
                categoriaAtual = "Todos os Amigurumis";
            }
            else
            {
                amigurumis = _amigurumiRepository.Amigurumis
                    .Where(a => a.Categoria.CategoriaNome.Equals(categoria))
                    .OrderBy(c => c.Nome);

                categoriaAtual = categoria;
            }

            var amigurumisListViewModel = new AmigurumiListViewModel
            {
                Amigurumis = amigurumis,
                CategoriaAtual = categoriaAtual
            };

            return View(amigurumisListViewModel);
        }
    }
}
