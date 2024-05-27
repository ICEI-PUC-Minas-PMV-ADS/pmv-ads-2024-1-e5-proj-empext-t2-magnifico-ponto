namespace Correios.Demo.Services.Models
{
    public class PrazoResponse
    {
        public string coProduto { get; set; }

        public string nuRequisicao { get; set; }

        public int prazoEntrega { get; set; }

        public string dataMaxima { get; set; }

        public string txErro { get; set; }

        public string entregaDomiciliar { get; set; }

        public string entregaSabado { get; set; }

        public string msgPrazo { get; set; }
    }
}
