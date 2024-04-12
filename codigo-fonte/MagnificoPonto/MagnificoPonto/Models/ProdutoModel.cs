using MagnificoPonto.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagnificoPonto.Models
{
    [Table("Cadastro de Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Amigurumi")]
        [Required(ErrorMessage = "Insira o nome do item!")]
        public string Nome { get; set; }

        [Display(Name = "Referência")]
        [Required(ErrorMessage = "Insira a referência do item!")]
        public string Referencia { get; set; }

        [Display(Name = "Cor Predominante")]
        [Required(ErrorMessage = "Informe a cor predominante do item!")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Informe o tamanho do item!")]
        public string Tamanho { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        [Required(ErrorMessage = "Informe o preço do item!")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria para o item!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Insira uma descrição para o item!")]
        [StringLength(5000)]
        [Display(Name = "Descrição do item")]
        public string Descrição { get; set; }

        [Display(Name = "Tempo para confecção")]
        [Required(ErrorMessage = "Informe o prazo para a confecção do item!")]
        public int TempoConfeccao { get; set; }

        [Display(Name = "Pronta Entrega")]
        [Required(ErrorMessage = "Informe se o produto possui estoque!")]
        public bool ProntaEntrega { get; set; }

        [Display(Name = "Upload da imagem")]
      //[Required(ErrorMessage = "Insira uma imagem do produto!")]
        public string ImageFileName { get; set; }
    }
}
