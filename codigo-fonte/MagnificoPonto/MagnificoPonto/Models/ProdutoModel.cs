using MagnificoPonto.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagnificoPonto.Models
{
    [Display(Name = "Cadastro de Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome do Amigurumi")]
        [Required(ErrorMessage = "Insira o nome do item!")]
        public string Nome { get; set; }
        [Display(Name = "Referência")]
        [Required(ErrorMessage = "Insira a referência do item!")]
        public double Referencia { get; set; }
        [Display(Name = "Cor Predominante")]
        [Required(ErrorMessage = "Informe a cor predominante do item!")]
        public CorType Cor { get; set; }
        [Required(ErrorMessage = "Informe o tamanho do item!")]
        public TamanhoType Tamanho { get; set; }
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Informe o preço do item!")]
        public decimal Preco { get; set; }        
        [Display(Name = "Tempo para confecção")]
        [Required(ErrorMessage = "Informe o prazo para a confecção do item!")]
        public int TempoConfeccao { get; set; }
        [Display(Name = "Pronta Entrega")]
        [Required(ErrorMessage = "Informe se o produto possui estoque!")]
        public bool ProntaEntrega { get; set; }
    }
}
