using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagnificoPonto.Data;
using MagnificoPonto.Models;

namespace MagnificoPonto.Controllers
{
    public class RelatorioVendasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelatorioVendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RelatorioVendas
        public async Task<IActionResult> Index()
        {
              return View(await _context.RelatorioVendas.ToListAsync());
        }

        // GET: RelatorioVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RelatorioVendas == null)
            {
                return NotFound();
            }

            var relatorioVendasModel = await _context.RelatorioVendas
                .FirstOrDefaultAsync(m => m.RelatorioVendasModelId == id);
            if (relatorioVendasModel == null)
            {
                return NotFound();
            }

            return View(relatorioVendasModel);
        }

        // GET: RelatorioVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RelatorioVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RelatorioVendasModelId,Nome,Email,Telefone,PlataformaVenda,Criacao,Amigurumi,Quantidade,ValorTotal,TempoConfeccao,Personalizacao,Categoria,Observacao,ImageFileName")] RelatorioVendasModel relatorioVendasModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relatorioVendasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relatorioVendasModel);
        }

        // GET: RelatorioVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RelatorioVendas == null)
            {
                return NotFound();
            }

            var relatorioVendasModel = await _context.RelatorioVendas.FindAsync(id);
            if (relatorioVendasModel == null)
            {
                return NotFound();
            }
            return View(relatorioVendasModel);
        }

        // POST: RelatorioVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RelatorioVendasModelId,Nome,Email,Telefone,PlataformaVenda,Criacao,Amigurumi,Quantidade,ValorTotal,TempoConfeccao,Personalizacao,Categoria,Observacao,ImageFileName")] RelatorioVendasModel relatorioVendasModel)
        {
            if (id != relatorioVendasModel.RelatorioVendasModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatorioVendasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioVendasModelExists(relatorioVendasModel.RelatorioVendasModelId))
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
            return View(relatorioVendasModel);
        }

        // GET: RelatorioVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RelatorioVendas == null)
            {
                return NotFound();
            }

            var relatorioVendasModel = await _context.RelatorioVendas
                .FirstOrDefaultAsync(m => m.RelatorioVendasModelId == id);
            if (relatorioVendasModel == null)
            {
                return NotFound();
            }

            return View(relatorioVendasModel);
        }

        // POST: RelatorioVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RelatorioVendas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RelatorioVendas'  is null.");
            }
            var relatorioVendasModel = await _context.RelatorioVendas.FindAsync(id);
            if (relatorioVendasModel != null)
            {
                _context.RelatorioVendas.Remove(relatorioVendasModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatorioVendasModelExists(int id)
        {
          return _context.RelatorioVendas.Any(e => e.RelatorioVendasModelId == id);
        }
    }
}
