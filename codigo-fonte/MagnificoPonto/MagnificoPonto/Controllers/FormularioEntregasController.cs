using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagnificoPonto.Data;
using MagnificoPonto.Models;
using Microsoft.AspNetCore.Authorization;

namespace MagnificoPonto.Controllers
{
    
    public class FormularioEntregasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormularioEntregasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FormularioEntregas
        public async Task<IActionResult> Index()
        {
              return View(await _context.FormularioEntregas.ToListAsync());
        }

        // GET: FormularioEntregas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FormularioEntregas == null)
            {
                return NotFound();
            }

            var formularioEntrega = await _context.FormularioEntregas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formularioEntrega == null)
            {
                return NotFound();
            }

            return View(formularioEntrega);
        }

        // GET: FormularioEntregas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormularioEntregas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Telefone,Rua,Numero,Bairro,Cep,Referencia,Criacao")] FormularioEntrega formularioEntrega)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formularioEntrega);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formularioEntrega);
        }

        // GET: FormularioEntregas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FormularioEntregas == null)
            {
                return NotFound();
            }

            var formularioEntrega = await _context.FormularioEntregas.FindAsync(id);
            if (formularioEntrega == null)
            {
                return NotFound();
            }
            return View(formularioEntrega);
        }

        // POST: FormularioEntregas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Telefone,Rua,Numero,Bairro,Cep,Referencia,Criacao")] FormularioEntrega formularioEntrega)
        {
            if (id != formularioEntrega.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formularioEntrega);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormularioEntregaExists(formularioEntrega.Id))
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
            return View(formularioEntrega);
        }

        // GET: FormularioEntregas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FormularioEntregas == null)
            {
                return NotFound();
            }

            var formularioEntrega = await _context.FormularioEntregas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formularioEntrega == null)
            {
                return NotFound();
            }

            return View(formularioEntrega);
        }

        // POST: FormularioEntregas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FormularioEntregas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FormularioEntregas'  is null.");
            }
            var formularioEntrega = await _context.FormularioEntregas.FindAsync(id);
            if (formularioEntrega != null)
            {
                _context.FormularioEntregas.Remove(formularioEntrega);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormularioEntregaExists(int id)
        {
          return _context.FormularioEntregas.Any(e => e.Id == id);
        }
    }
}
