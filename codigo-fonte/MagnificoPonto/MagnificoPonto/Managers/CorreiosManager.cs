using Correios.Demo.Services.Models;
using Correios.Demo.Services;
using MagnificoPonto.Models;
using System.Text.RegularExpressions;

namespace Correios.Demo
{
    public static class CorreiosManager
    {
        private readonly static string _correiosUrl = "https://api.correios.com.br";

        private readonly static string _usuario = "hgimporthom"; // modificar depois

        private readonly static string _codigoAcesso = "9QFAX2Sjr3uGB5OQrBhQvHSVG2uIzXxk1Jgkr7jc"; // modificar depois //XgcyoyuOak8Eu5XhopZwpBuFgIThHB5OiNPS6rGN


        private readonly static string _cartaoPostagem = "0073249300"; // modificar depois
        private readonly static string _codigoServicoContratoPAC = "03298";
        private readonly static string _codigoServicoContratoSedex = "03220";
        private readonly static string _codigoServicoContratoSedex10 = "03158";
        private readonly static string _codigoServicoContratoSedexHoje = "";
        private readonly static string _codigoServicoContratoMiniEnvio = "03450";

        //TODO: armazenar no banco de dados
        private static string _contrato;
        private static int _dr;
        private static string _token;
        private static DateTime _expiracaotokenUTC;

        public static List<string> CalcularPrecoPrazo(string cepOrigem, string cepDestino, ProdutoModel item)
        {
            var volume = (double)0;

            double peso = 0;
            
            var comprimentoItem = 2;
            var larguraItem = 2;
            var alturaItem = ExtrairNumero(item.Tamanho);

            var volumeItem = (alturaItem * larguraItem * comprimentoItem);

            volume += volumeItem;

            volume *= item.Quantidade;

            peso += item.Peso;

            peso *= item.Quantidade;

            double potencia = 1.0 / 3.0;
            double raizCubica = Math.Pow(Convert.ToDouble(volume), potencia);

            var comprimento = Convert.ToDecimal(raizCubica);

            var altura = Convert.ToDecimal(raizCubica);

            var largura = Convert.ToDecimal(raizCubica);

            return GetPrecoPrazo(cepOrigem, cepDestino, altura, largura, comprimento, peso);
        }

        private static List<string> GetPrecoPrazo(string cepOrigem, string cepDestino, decimal altura, decimal largura, decimal comprimento, double peso)
        {
            var correiosService = new CorreiosService(_correiosUrl);

            UpdateCorreiosToken(correiosService);

            var codigoServicos = BuildCodigoServicosContrato();

            var precoRequest = new PrecoRequest();

            precoRequest.idLote = "1";
            precoRequest.parametrosProduto = new List<PrecoNacionalParam>();

            var prazoRequest = new PrazoRequest();

            prazoRequest.idLote = "1";
            prazoRequest.parametrosPrazo = new List<ParamPrazoNacional>();

            var token = _token;
            var contrato = _contrato;
            var dr = _dr;

            foreach (var codigoServico in codigoServicos)
            {
                var precoNacional = new PrecoNacionalParam
                {
                    cepOrigem = cepOrigem,
                    cepDestino = cepDestino,

                    nuContrato = contrato,
                    nuDR = dr,
                    nuRequisicao = "1",

                    tpObjeto = "2",
                    dtEvento = DateTime.Now.ToString("dd-MM-yyyy"),

                    altura = Math.Round(altura).ToString(),
                    largura = Math.Round(largura).ToString(),
                    diametro = "0",
                    comprimento = Math.Round(comprimento).ToString(),
                    psObjeto = Math.Round(peso).ToString(),
                    coProduto = codigoServico
                };

                var prazoNacional = new ParamPrazoNacional
                {
                    cepOrigem = cepOrigem,
                    cepDestino = cepDestino,
                    coProduto = codigoServico,
                    nuRequisicao = "1",
                    dtEvento = DateTime.Now.ToString("dd-MM-yyyy")
                };

                precoRequest.parametrosProduto.Add(precoNacional);
                prazoRequest.parametrosPrazo.Add(prazoNacional);
            }

            var precoResponse = correiosService.GetPreco(precoRequest, token);

            var prazoResponse = correiosService.GetPrazo(prazoRequest, token);

            var opcoesEntrega = GerarOpcoesEntrega(precoResponse, prazoResponse);

            return opcoesEntrega;
        }

        private static void UpdateCorreiosToken(CorreiosService correiosService)
        {
            var correiosToken = _token;
            var expiracaotokenUTC = _expiracaotokenUTC;

            if (string.IsNullOrEmpty(correiosToken) || CorreiosTokenExpired(expiracaotokenUTC))
            {
                var tokenResponse = correiosService.GetToken(_usuario, _codigoAcesso, _cartaoPostagem);

                _token = tokenResponse.token;
                _contrato = tokenResponse.cartaoPostagem.contrato;
                _dr = tokenResponse.cartaoPostagem.dr;
                _expiracaotokenUTC = tokenResponse.expiraEm;
            }
        }

        private static bool CorreiosTokenExpired(DateTime expiracaotokenUTC)
        {
            bool expired = (expiracaotokenUTC <= DateTime.UtcNow.AddMinutes(-30));

            return expired;
        }

        private static IList<string> BuildCodigoServicosContrato()
        {
            var codigos = new List<string>();

            if (!string.IsNullOrEmpty(_codigoServicoContratoPAC))
                codigos.Add(_codigoServicoContratoPAC);

            if (!string.IsNullOrEmpty(_codigoServicoContratoSedex))
                codigos.Add(_codigoServicoContratoSedex);

            if (!string.IsNullOrEmpty(_codigoServicoContratoSedex10))
                codigos.Add(_codigoServicoContratoSedex10);

            if (!string.IsNullOrEmpty(_codigoServicoContratoSedexHoje))
                codigos.Add(_codigoServicoContratoSedexHoje);

            if (!string.IsNullOrEmpty(_codigoServicoContratoMiniEnvio))
                codigos.Add(_codigoServicoContratoMiniEnvio);

            return codigos;
        }

        private static List<string> GerarOpcoesEntrega(IList<PrecoResponse> precos, IList<PrazoResponse> prazos)
        {
            var opcoesEntrega = new List<string>();

            foreach (var preco in precos)
            {
                var valor = !string.IsNullOrEmpty(preco.pcFinal) ? decimal.Parse(preco.pcFinal) : 0;

                if (valor > 0)
                {
                    var nome = ObterNomeServico(preco.coProduto);

                    var prazo = prazos.FirstOrDefault(c => c.coProduto == preco.coProduto);

                    var prazoEntrega = ObterPrazoEntrega(prazo);

                    var msgAdicional = (!string.IsNullOrEmpty(preco.txErro)) ? preco.txErro : string.Empty;

                    var opcaoEntrega = nome + " R$ " + valor.ToString() + " " + prazoEntrega + (!string.IsNullOrEmpty(preco.txErro) ? ". " + preco.txErro : string.Empty);

                    opcoesEntrega.Add(opcaoEntrega);
                }
            }

            return opcoesEntrega;
        }

        private static string ObterNomeServico(string codigoServico)
        {
            string nomeServico = string.Empty;

            if (codigoServico == _codigoServicoContratoPAC)
            {
                nomeServico = "PAC";
                return nomeServico;
            }
            else if (codigoServico == _codigoServicoContratoSedex)
            {
                nomeServico = "Sedex";
                return nomeServico;
            }
            else if (codigoServico == _codigoServicoContratoSedex10)
            {
                nomeServico = "Sedex 10";
                return nomeServico;
            }
            else if (codigoServico == _codigoServicoContratoSedexHoje)
            {
                nomeServico = "Sedex Hoje";
                return nomeServico;
            }
            else if (codigoServico == _codigoServicoContratoMiniEnvio)
            {
                nomeServico = "Mini Envio";
                return nomeServico;
            }

            return nomeServico;
        }

        private static string ObterPrazoEntrega(PrazoResponse prazo)
        {
            int diasEntrega = 0;

            if (prazo != null && string.IsNullOrEmpty(prazo.txErro))
            {
                diasEntrega = prazo.prazoEntrega;
            }

            if (diasEntrega == 0) return string.Empty;

            var diaUtil = diasEntrega == 1 ? "dia útil" : "dias úteis";

            var prazoEntrega = string.Format("até {0} {1}", diasEntrega, diaUtil);

            return prazoEntrega;
        }

        private static double ExtrairNumero(string input)
        {
            Match match = Regex.Match(input, @"(\d+(\.\d+)?)");

            if (match.Success)
            {
                return double.Parse(match.Value);
            }
            else
            {
                return 0;
            }
        }
    }
}
