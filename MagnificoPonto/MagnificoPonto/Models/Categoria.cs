namespace MagnificoPonto.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        public List<Amigurumi> Amigurumis { get; set; }
    }
}
