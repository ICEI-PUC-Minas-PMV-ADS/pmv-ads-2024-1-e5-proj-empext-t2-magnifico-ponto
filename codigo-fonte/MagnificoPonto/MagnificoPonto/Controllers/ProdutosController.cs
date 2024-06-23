using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagnificoPonto.Data;
using MagnificoPonto.Models;
using System.Reflection;

namespace MagnificoPonto.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private string caminhoServidor;

        public ProdutosController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            caminhoServidor = environment.WebRootPath;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Produtos.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoModel produtoModel, IFormFile foto)
        {
            string caminhoParaSalvarImagem = caminhoServidor + "\\Amigurumis\\";
            string novoNomeParaImagem = Guid.NewGuid().ToString() + "_" + foto.FileName;

            if (!Directory.Exists(caminhoParaSalvarImagem))
            {
                Directory.CreateDirectory(caminhoParaSalvarImagem);
            }

            using (var stream = System.IO.File.Create(caminhoParaSalvarImagem + novoNomeParaImagem))
            {
                foto.CopyTo(stream);
            }

            produtoModel.ImageFileName = novoNomeParaImagem;

            if (ModelState.IsValid)
            {
                _context.Add(produtoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoModel);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.Produtos.FindAsync(id);
            if (produtoModel == null)
            {
                return NotFound();
            }
            return View(produtoModel);
        }

        // POST: Produtos/Edit/5        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdutoModel produtoModel, IFormFile foto)
        {
            if (id != produtoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string caminhoParaSalvarImagem = caminhoServidor + "\\Amigurumis\\";
                string novoNomeParaImagem = Guid.NewGuid().ToString() + "_" + foto.FileName;

                if (!Directory.Exists(caminhoParaSalvarImagem))
                {
                    Directory.CreateDirectory(caminhoParaSalvarImagem);
                }

                using (var stream = System.IO.File.Create(caminhoParaSalvarImagem + novoNomeParaImagem))
                {
                    foto.CopyTo(stream);
                }

                produtoModel.ImageFileName = novoNomeParaImagem;

                try
                {
                    _context.Update(produtoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoModelExists(produtoModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produtoModel);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Produtos'  is null.");
            }
            var produtoModel = await _context.Produtos.FindAsync(id);
            if (produtoModel != null)
            {
                _context.Produtos.Remove(produtoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoModelExists(int id)
        {
          return _context.Produtos.Any(e => e.Id == id);
        }

       

    }
}
