using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MagnificoPonto.Models
{
    [Table("FormularioEntrega")]
    public class FormularioEntrega
    {
        public int Id { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "Insira seu nome completo!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira seu endereço de email para contato!")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Insira seu telefone para contato!")]
        public string Telefone { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Insira o nome da rua referente ao endereço de entrega!")]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Insira o número referente ao endereço de entrega!")]
        public int Numero { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Insira o nome do bairro referente ao endereço de entrega!")]
        public string Bairro { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Insira o número de CEP referente ao endereço de entrega!")]
        public int Cep { get; set; }

        [Display(Name = "Ponto de referência")]
        public string Referencia { get; set; }

        [Display(Name = "Data de criação do pedido")]
        public DateTime Criacao { get; set; } = DateTime.Now;
    }
}
