using MagnificoPonto.Context;
using MagnificoPonto.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminAmigurumisController : Controller
    {
        private readonly AppDbContext _context;

        public AdminAmigurumisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminAmigurumis
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Amigurumis.Include(l => l.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/AdminAmigurumis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigurumi = await _context.Amigurumis
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.AmigurumiId == id);
            if (amigurumi == null)
            {
                return NotFound();
            }

            return View(amigurumi);
        }

        // GET: Admin/AdminAmigurumis/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");
            return View();
        }

        // POST: Admin/AdminAmigurumis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmigurumiId,Nome,Descricao,Cor,Preco,Tamanho,ImagemUrl,ImagemThumbnailUrl,AmigurumiLancamento,EmEstoque,CategoriaId,TempoConfec")] Amigurumi amigurumi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amigurumi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", amigurumi.CategoriaId);
            return View(amigurumi);
        }

        // GET: Admin/AdminAmigurumis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigurumi = await _context.Amigurumis.FindAsync(id);
            if (amigurumi == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", amigurumi.CategoriaId);
            return View(amigurumi);
        }

        // POST: Admin/AdminAmigurumis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AmigurumiId,Nome,Descricao,Cor,Preco,Tamanho,ImagemUrl,ImagemThumbnailUrl,AmigurumiLancamento,EmEstoque,CategoriaId,TempoConfec")] Amigurumi amigurumi)
        {
            if (id != amigurumi.AmigurumiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amigurumi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmigurumiExists(amigurumi.AmigurumiId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", amigurumi.CategoriaId);
            return View(amigurumi);
        }

        // GET: Admin/AdminAmigurumis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigurumi = await _context.Amigurumis
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.AmigurumiId == id);
            if (amigurumi == null)
            {
                return NotFound();
            }

            return View(amigurumi);
        }

        // POST: Admin/AdminAmigurumis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amigurumi = await _context.Amigurumis.FindAsync(id);
            _context.Amigurumis.Remove(amigurumi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmigurumiExists(int id)
        {
            return _context.Amigurumis.Any(e => e.AmigurumiId == id);
        }
    }
}
