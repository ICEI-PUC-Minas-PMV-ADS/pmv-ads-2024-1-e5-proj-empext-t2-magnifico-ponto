using MagnificoPonto.Context;
using MagnificoPonto.Models;
using MagnificoPonto.Repositories.Interfaces;

namespace MagnificoPonto.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    AmigurumiId = carrinhoItem.Amigurumi.AmigurumiId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Amigurumi.Preco
                };
                _appDbContext.PedidoDetalhes.Add(pedidoDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}
