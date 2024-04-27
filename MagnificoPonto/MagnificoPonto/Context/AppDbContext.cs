using MagnificoPonto.Models;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {  
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Amigurumi> Amigurumis { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get;}
    }
}
