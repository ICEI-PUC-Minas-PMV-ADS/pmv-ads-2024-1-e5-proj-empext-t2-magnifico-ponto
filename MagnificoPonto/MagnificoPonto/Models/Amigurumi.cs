using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagnificoPonto.Models
{
    [Table("Amigurumis")]
    public class Amigurumi
    {
        [Key]
        public int AmigurumiId { get; set; }

        [Required(ErrorMessage = "O nome do amigurumi deve ser informado")]
        [Display(Name = "Nome do Amigurumi")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Uma descrição detalhada deve ser adicionada")]
        [Display(Name = "Descrição Detalhada")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Um preço deve ser informado")]
        [Display(Name = "Preço R$")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99 reais")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Um tamanho deve ser informado!")]
        [Display(Name = "Tamanho")]
        [StringLength(200)]
        public string Tamanho { get; set; }

        [Required(ErrorMessage = "Tempo de confecção deve ser informado!")]
        [Display(Name = "Tempo de confecção em dias úteis")]
        public int TempoConfec { get; set; }

        [Required(ErrorMessage = "Uma cor deve ser informada!")]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        public string Personalizacao { get; set; }

        [Display(Name = "Lançamento?")]
        public bool AmigurumiLancamento { get; set; }

        [Display(Name = "Em Estoque")]
        public bool EmEstoque { get; set; }

        [NotMapped]
        public DateTime DataCriacao { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set;}
    }
}