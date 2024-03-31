namespace MagnificoPonto.Models
{
    public class Amigurumi
    {
        public string AmigurumiId { get; set; }

        public string Nome { get; set; }

        public string DescricaoCurta { get; set; }

        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool AmigurumiLancamento { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set;}
    }
}
