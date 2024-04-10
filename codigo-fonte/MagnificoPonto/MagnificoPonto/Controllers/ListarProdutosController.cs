using MagnificoPonto.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
