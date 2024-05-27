namespace Correios.Demo.Services.Models
{
    public class PrecoResponse
    {

        public string coProduto { get; set; }

        public string noProduto { get; set; }

        public string pcBase { get; set; }

        public string pcBaseGeral { get; set; }

        public string peVariacao { get; set; }

        public string pcReferencia { get; set; }

        public BeneficioResponse[] beneficios { get; set; }

        public string vlBaseCalculoImposto { get; set; }

        public string nuRequisicao { get; set; }

        public string inPesoCubico { get; set; }

        public string psCobrado { get; set; }

        public PrecoServicoAdicional[] servicoAdicional { get; set; }

        public string peAdValorem { get; set; }

        public string vlSeguroAutomatico { get; set; }

        public string qtAdicional { get; set; }

        public string pcFaixa { get; set; }

        public string pcCadaAdicional { get; set; }

        public string pcTotalAdicional { get; set; }

        public string pcFaixaVariacao { get; set; }

        public string pcCadaAdicionalVariacao { get; set; }

        public string pcTotalAdicionalVariacao { get; set; }

        public string vlTotalDescVariacao { get; set; }

        public string vlTotalBeneficios { get; set; }

        public string pcProduto { get; set; }

        public string pcTotalServicosAdicionais { get; set; }

        public string pcFinal { get; set; }

        public string txErro { get; set; }

        public InfoAdicionalResponse[] infoAdicional { get; set; }

        public string nomeProduto { get; set; }

        public string peIsencaoArmazenagem { get; set; }

        public TaxaExtraResponse taxaExtra { get; set; }
    }

    public class TaxaExtraResponse
    {
        public string codigo { get; set; }
        public string tipo { get; set; }
        public string vlTaxa { get; set; }
    }

    public class InfoAdicionalResponse
    {
        public string tipo { get; set; }

        public string valor { get; set; }
    }

    public class PrecoServicoAdicional
    {
        public string coServAdicional { get; set; }

        public string tpServAdicional { get; set; }

        public string pcServicoAdicional { get; set; }
    }

    public class BeneficioResponse
    {
        public string codigo { get; set; }

        public string tipoBeneficio { get; set; }

        public string tipo { get; set; }

        public string abrangencia { get; set; }

        public string coPacote { get; set; }

        public string noPacote { get; set; }

        public string incondicional { get; set; }

        public CriterioAtendidoResponse criterio { get; set; }

        public string vlBaseCalculo { get; set; }

        public string percentual { get; set; }

        public string valor { get; set; }
    }

    public class CriterioAtendidoResponse
    {
        public string nuCriterio { get; set; }

        public string noCriterio { get; set; }

        public string atendido { get; set; }

        public string peNegociado { get; set; }

        public string peConcedido { get; set; }
    }
}