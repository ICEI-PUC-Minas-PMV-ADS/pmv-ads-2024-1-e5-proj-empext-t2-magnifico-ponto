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

        public IActionResult Details (int amigurumiId)
        {
            var amigurumi = _amigurumiRepository.Amigurumis.FirstOrDefault(a=> a.AmigurumiId == amigurumiId);

            return View(amigurumi);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Amigurumi> amigurumis;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                amigurumis = _amigurumiRepository.Amigurumis.OrderBy(p => p.AmigurumiId);
                categoriaAtual = "Todos os Amigurumis";
            }
            else
            {
                amigurumis = _amigurumiRepository.Amigurumis
                             .Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

                if (amigurumis.Any())

                    categoriaAtual = "Amigurumis";

                else

                    categoriaAtual = "Nenhum Amigurumi foi encontrado";
            }

            return View("~/Views/Amigurumi/List.cshtml", new AmigurumiListViewModel
            {
                Amigurumis = amigurumis,
                CategoriaAtual = categoriaAtual
            });
        }
    }
}
