using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMax.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AspMax;Integrated Security=True");
        }
    }
}
