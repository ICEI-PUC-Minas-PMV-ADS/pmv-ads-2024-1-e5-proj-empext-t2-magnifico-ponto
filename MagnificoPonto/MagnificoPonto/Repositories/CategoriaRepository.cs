using MagnificoPonto.Context;
using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;

namespace MagnificoPonto.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
