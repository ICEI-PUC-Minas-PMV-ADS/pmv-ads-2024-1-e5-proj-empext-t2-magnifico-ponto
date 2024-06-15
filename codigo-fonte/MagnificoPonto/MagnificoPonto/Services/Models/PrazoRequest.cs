namespace Correios.Demo.Services.Models
{
    public class PrazoRequest
    {
        public string idLote { get; set; }

        public IList<ParamPrazoNacional> parametrosPrazo { get; set; }
    }

    public class ParamPrazoNacional
    {
        public string coProduto { get; set; }

        public string nuRequisicao { get; set; }

        public string dtEvento { get; set; }

        public string cepOrigem { get; set; }

        public string cepDestino { get; set; }

        public string dataPostagem { get; set; }
    }
}
