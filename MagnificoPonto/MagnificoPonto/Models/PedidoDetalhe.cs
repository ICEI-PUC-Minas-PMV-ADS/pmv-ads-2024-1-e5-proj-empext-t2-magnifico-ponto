using System.ComponentModel.DataAnnotations.Schema;

namespace MagnificoPonto.Models
{
    [Table("PedidoDetalhes")]
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }

        public int PedidoId { get; set; }

        public int AmigurumiId { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public virtual Amigurumi Amigurumi { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
