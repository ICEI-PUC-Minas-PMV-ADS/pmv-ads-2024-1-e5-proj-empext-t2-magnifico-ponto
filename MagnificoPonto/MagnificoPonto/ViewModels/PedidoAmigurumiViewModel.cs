using MagnificoPonto.Models;

namespace MagnificoPonto.ViewModels
{
    public class PedidoAmigurumiViewModel
    {
        public Pedido Pedido { get; set; }

        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set;}
    }
}
