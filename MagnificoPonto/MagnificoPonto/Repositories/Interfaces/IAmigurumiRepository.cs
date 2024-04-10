using MagnificoPonto.Models;

namespace MagnificoPonto.Repositories.Interfaces
{
    public interface IAmigurumiRepository
    {
        IEnumerable <Amigurumi> Amigurumis { get; }

        IEnumerable <Amigurumi> AmigurumiLancamento { get; }

        Amigurumi GetAmigurumiById (int amigurumiId);
    }
}
