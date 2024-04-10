using MagnificoPonto.Models;

namespace MagnificoPonto.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable <Categoria> Categorias { get; }
    }
}
