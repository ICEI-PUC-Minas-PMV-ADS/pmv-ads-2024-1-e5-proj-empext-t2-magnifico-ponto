using MagnificoPonto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Data
{
    public class ApplicationDbContext : IdentityDbContext <IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }        
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<FormularioEntrega> FormularioEntregas { get; set; }
        public DbSet<VendaProdutosModel> VendaProdutos { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
