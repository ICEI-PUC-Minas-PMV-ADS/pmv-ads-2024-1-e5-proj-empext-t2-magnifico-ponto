namespace Correios.Demo.Services.Models
{
    public class TokenResponse
    {
        public string ambiente { get; set; }

        public string id { get; set; }

        public string ip { get; set; }

        public string perfil { get; set; }

        public string cnpj { get; set; }

        public int? pjInternacional { get; set; }

        public string cpf { get; set; }

        public string cie { get; set; }

        public CartaoPostagem cartaoPostagem { get; set; }

        public Contrato contrato { get; set; }

        public DateTime emissao { get; set; }

        public DateTime expiraEm { get; set; }

        public string zoneOffset { get; set; }

        public string token { get; set; }
    }

    public class CartaoPostagem
    {
        public string numero { get; set; }

        public string contrato { get; set; }

        public int dr { get; set; }

        public int[] api { get; set; }
    }

    public class Contrato
    {
        public string numero { get; set; }

        public int dr { get; set; }

        public int[] api { get; set; }
    }
}
