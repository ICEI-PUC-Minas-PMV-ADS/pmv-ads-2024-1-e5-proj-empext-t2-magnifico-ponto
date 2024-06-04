using MagnificoPonto.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace MagnificoPonto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficosVendasService _graficoVendas;

        public AdminGraficoController(GraficosVendasService graficoVendas)
        {
            _graficoVendas = graficoVendas ?? throw new ArgumentNullException(nameof(graficoVendas));
        }

        public JsonResult VendasAmigurumis(int dias)
        {
            var amigurumisVendasTotais = _graficoVendas.GetVendasAmigurumis(dias);
            return Json(amigurumisVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }
    }
}
