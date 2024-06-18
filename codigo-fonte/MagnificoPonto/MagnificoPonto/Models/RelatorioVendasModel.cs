using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace MagnificoPonto.Models
{
    [Table("RelatorioVendas")]
    public class RelatorioVendasModel
    {
        [Key]
        public int RelatorioVendasModelId { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Insira o nome do cliente!")]
        public string Nome { get; set; }

        [Display(Name = "Email do cliente")]
        [Required(ErrorMessage = "Insira o email do cliente!")]
        public string Email { get; set; }

        [Display(Name = "Telefone do cliente")]
        [Required(ErrorMessage = "Insira o telefone de contato do cliente!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Insira o nome da plataforma que foi realizada a venda do item!")]
        [StringLength(5000)]
        [Display(Name = "Plataforma de venda do item")]
        public string PlataformaVenda { get; set; }

        [Display(Name = "Data da venda")]
        [Required(ErrorMessage = "Insira a data de venda do produto!")]
        public DateTime Criacao { get; set; }


        [Display(Name = "Nome do Amigurumi")]
        [Required(ErrorMessage = "Insira o nome do Amigurumi!")]
        public string Amigurumi { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Insira a quantidade disponível do item!")]
        public int Quantidade { get; set; }

        [Display(Name = "Valor total do pedido")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        [Required(ErrorMessage = "Insira o valor total do pedido!")]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Prazo total (em dias) para a confecção")]
        [Required(ErrorMessage = "Informe o prazo total (em dias) para finalizar a confecção!")]
        public int TempoConfeccao { get; set; }
       
        [StringLength(5000)]
        [Display(Name = "Personalização do item")]
        public string Personalizacao { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria para o item!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Insira uma descrição para o item!")]
        [StringLength(5000)]
        [Display(Name = "Observação sobre o item e/ou venda")]
        public string Observacao { get; set; }        

        [Display(Name = "Upload da imagem")]
        //[Required(ErrorMessage = "Insira uma imagem do produto!")]
        public string ImageFileName { get; set; }
               

    }
}
