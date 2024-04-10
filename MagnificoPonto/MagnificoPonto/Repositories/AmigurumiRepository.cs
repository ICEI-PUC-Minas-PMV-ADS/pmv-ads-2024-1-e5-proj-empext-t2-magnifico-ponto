using MagnificoPonto.Context;
using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Repositories
{
    public class AmigurumiRepository : IAmigurumiRepository
    {
        private readonly AppDbContext _context;
        public AmigurumiRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Amigurumi> Amigurumis => _context.Amigurumis.Include(c=> c.Categoria);

        public IEnumerable<Amigurumi> AmigurumiLancamento => _context.Amigurumis
            .Where(a => a.AmigurumiLancamento)
            .Include(c=>c.Categoria);

        public Amigurumi GetAmigurumiById(int amigurumiId)
        {
            return _context.Amigurumis.FirstOrDefault(a => a.AmigurumiId == amigurumiId);
        }
    }
}
