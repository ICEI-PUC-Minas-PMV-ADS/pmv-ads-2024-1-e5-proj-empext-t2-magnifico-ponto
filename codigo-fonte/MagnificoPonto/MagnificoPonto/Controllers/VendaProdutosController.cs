using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagnificoPonto.Data;
using MagnificoPonto.Models;
using MagnificoPonto.Services.Models;
using MagnificoPonto.Services;
using Newtonsoft.Json;

namespace MagnificoPonto.Controllers
{
    public class VendaProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendaProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VendaProdutos
        public async Task<IActionResult> Index()
        {
              return View(await _context.VendaProdutos.ToListAsync());
        }

        // GET: VendaProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VendaProdutos == null)
            {
                return NotFound();
            }

            var vendaProdutosModel = await _context.VendaProdutos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendaProdutosModel == null)
            {
                return NotFound();
            }

            return View(vendaProdutosModel);
        }

        // GET: VendaProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendaProdutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Preco,Cor,Tamanho,Quantidade,Personalizacao,CriadoEm")] VendaProdutosModel vendaProdutosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendaProdutosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendaProdutosModel);
        }

        // GET: VendaProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VendaProdutos == null)
            {
                return NotFound();
            }

            var vendaProdutosModel = await _context.VendaProdutos.FindAsync(id);
            if (vendaProdutosModel == null)
            {
                return NotFound();
            }
            return View(vendaProdutosModel);
        }

        // POST: VendaProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Preco,Cor,Tamanho,Quantidade,Personalizacao,CriadoEm")] VendaProdutosModel vendaProdutosModel)
        {
            if (id != vendaProdutosModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaProdutosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaProdutosModelExists(vendaProdutosModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));  //return RedirectToAction(nameof(Index));
            }
            return View(vendaProdutosModel);
        }

        // GET: VendaProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VendaProdutos == null)
            {
                return NotFound();
            }

            var vendaProdutosModel = await _context.VendaProdutos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendaProdutosModel == null)
            {
                return NotFound();
            }

            return View(vendaProdutosModel);
        }

        // POST: VendaProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VendaProdutos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.VendaProdutos'  is null.");
            }
            var vendaProdutosModel = await _context.VendaProdutos.FindAsync(id);
            if (vendaProdutosModel != null)
            {
                _context.VendaProdutos.Remove(vendaProdutosModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaProdutosModelExists(int id)
        {
          return _context.VendaProdutos.Any(e => e.Id == id);
        }

        // Listagem de Produtos

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

            TempData["Result"] = result;

            return RedirectToAction("InfoProdutos", new { id = model.Id });
        }
    }
}
