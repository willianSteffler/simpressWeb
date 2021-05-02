using Microsoft.EntityFrameworkCore;
using SimpressWeb.Models.DbModels.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpressWeb.Models.DbModels
{
    public class SimpressDAO : DbContext
    {
        public SimpressDAO(DbContextOptions<SimpressDAO> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("tblProduto");
            modelBuilder.Entity<Categoria>().ToTable("tblCategoriaProduto");

            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
        }
    }
}
