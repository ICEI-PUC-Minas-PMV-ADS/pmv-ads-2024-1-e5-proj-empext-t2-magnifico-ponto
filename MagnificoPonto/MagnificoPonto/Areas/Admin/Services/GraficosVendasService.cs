using MagnificoPonto.Context;
using MagnificoPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MagnificoPonto.Areas.Admin.Services
{
    public class GraficosVendasService
    {
        private readonly AppDbContext context;

        public GraficosVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public List<AmigurumiGrafico> GetVendasAmigurumis(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var amigurumis = (from pd in context.PedidoDetalhes 
                              join a in context.Amigurumis on pd.AmigurumiId equals a.AmigurumiId 
                              where pd.Pedido.PedidoEnviado >= data 
                              group pd by new { pd.AmigurumiId, a.Nome} 
                              into g
                              select new
                              {
                                  AmigurumiNome = g.Key.Nome,
                                  AmigurumisQuantidade = g.Sum(q => q.Quantidade),
                                  AmigurumisValorTotal = g.Sum(t => t.Preco * t.Quantidade)
                              });

            var lista = new List<AmigurumiGrafico>();

            foreach(var item in amigurumis)
            {
                var amigurumi = new AmigurumiGrafico();
                amigurumi.AmigurumiNome = item.AmigurumiNome;
                amigurumi.AmigurumisQuantidade = item.AmigurumisQuantidade;
                amigurumi.AmigurumisValorTotal = item.AmigurumisValorTotal;
                lista.Add(amigurumi);
            }

            return lista;
        }
    }
}
