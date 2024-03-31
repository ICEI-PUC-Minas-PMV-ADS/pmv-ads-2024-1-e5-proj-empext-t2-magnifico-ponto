using MagnificoPonto.Models;
using Microsoft.EntityFrameworkCore;

namespace MagnificoPonto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {  
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Amigurumi> Amigurumis { get; set; }
    }
}
