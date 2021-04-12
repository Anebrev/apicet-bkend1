using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CETtst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>().Property(p => p.nome).HasMaxLength(80);
            modelBuilder.Entity<Produto>().Property(p => p.preco).HasPrecision(10,2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { id = 1, nome = "Caderno2", preco = 7.95m, estoque = 10 },
                    new Produto { id = 2, nome = "Borracha", preco = 2.45m, estoque = 30 },
                    new Produto { id = 3, nome = "Estojo", preco = 6.25m, estoque = 15 }
                );
        }

    }

}

