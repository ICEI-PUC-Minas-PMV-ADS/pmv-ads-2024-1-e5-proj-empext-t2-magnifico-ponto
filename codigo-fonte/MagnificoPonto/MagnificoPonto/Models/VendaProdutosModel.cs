﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagnificoPonto.Models
{
    [Table("VendaProdutos")]
    public class VendaProdutosModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }


        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Selecione a quantidade")]
        public int Quantidade { get; set; }

        [StringLength(5000)]
        [Display(Name = "Personalização")]
        public string Personalizacao { get; set; }

        [Display(Name = "Data de criação do pedido")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
