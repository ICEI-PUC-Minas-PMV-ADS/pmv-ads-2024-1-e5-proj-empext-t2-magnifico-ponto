using MagnificoPonto.Data;
using MagnificoPonto.Models;
using MagnificoPonto.Services;
using MagnificoPonto.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MagnificoPonto.Controllers
{
    public class ListarProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ListarProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaProdutos()
        {
            var listarProdutos = await _context.Produtos.ToListAsync();
            return View(listarProdutos);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> InfoProdutos(int? id)
        {

            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(string id, string cepDestino)
        {
            ProdutoModel model = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == Convert.ToInt32(id));

            if (cepDestino == null)
                return RedirectToAction("InfoProdutos", new { id = model.Id });

            var result = await MelhorEnvioService.teste(model, cepDestino);
            List<MelhorEnvioResponse> rootList = JsonConvert.DeserializeObject<List<MelhorEnvioResponse>>(result.Content);
            string valueToShow = "";

            foreach(var item in rootList)
            {
                valueToShow += $"Serviço: {item.name} \n Preço: {item.price} \n";
            }

            TempData["Result"] = valueToShow;

            return RedirectToAction("InfoProdutos", new { id = model.Id });
        }
    }
}
