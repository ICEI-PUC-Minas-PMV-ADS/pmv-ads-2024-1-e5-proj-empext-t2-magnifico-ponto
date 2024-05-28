using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MagnificoPonto.Models
{
    [Table("FormularioEntrega")]
    public class FormularioEntrega
    {

        
        
            public int Id { get; set; }

            [Display(Name = "Nome completo")]
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string Rua { get; set; }
            [Display(Name = "Número")]
            public int Numero { get; set; }
            public string Bairro { get; set; }
            public int Cep { get; set; }

            [Display(Name = "Ponto de referência")]
            public string Referencia { get; set; }

            [Display(Name = "Data de criação do pedido")]
            public DateTime Criacao { get; set; } = DateTime.Now;
    }
}
