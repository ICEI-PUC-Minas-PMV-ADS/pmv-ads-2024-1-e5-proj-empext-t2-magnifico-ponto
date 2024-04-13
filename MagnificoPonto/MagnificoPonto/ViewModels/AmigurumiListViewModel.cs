using MagnificoPonto.Models;

namespace MagnificoPonto.ViewModels
{
    public class AmigurumiListViewModel
    {
        public IEnumerable<Amigurumi> Amigurumis { get; set; }

        public string CategoriaAtual { get; set; }
    }
}
