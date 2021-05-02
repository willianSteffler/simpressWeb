using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpressWeb.Models.DbModels.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                new Categoria
                {
                    Ativo = true,
                    Nome = "Eletrônico",
                    Descricao = "Eletrodomésticos",
                    ID = 1
                },
                new Categoria
                {
                    Ativo = true,
                    Nome = "Informática",
                    Descricao = "Produtos para Informática",
                    ID = 2
                },
                new Categoria
                {
                    Ativo = true,
                    Nome = "Celulares",
                    Descricao = "Aparelhos e acessórios",
                    ID = 3
                },
                new Categoria
                {
                    Ativo = true,
                    Nome = "Moda",
                    Descricao = "Artigos para vestuário em geral",
                    ID = 4
                },
                new Categoria
                {
                    Ativo = true,
                    Nome = "Livros",
                    Descricao = "Livros",
                    ID = 5
                }
            );
        }
    }
}
