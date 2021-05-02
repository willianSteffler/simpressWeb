﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpressWeb.Models.DbModels;

namespace SimpressWeb.Migrations
{
    [DbContext(typeof(SimpressDAO))]
    partial class SimpressDAOModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpressWeb.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("tblCategoriaProduto");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Ativo = true,
                            Descricao = "Eletrodomésticos",
                            Nome = "Eletrônico"
                        },
                        new
                        {
                            ID = 2,
                            Ativo = true,
                            Descricao = "Produtos para Informática",
                            Nome = "Informática"
                        },
                        new
                        {
                            ID = 3,
                            Ativo = true,
                            Descricao = "Aparelhos e acessórios",
                            Nome = "Celulares"
                        },
                        new
                        {
                            ID = 4,
                            Ativo = true,
                            Descricao = "Artigos para vestuário em geral",
                            Nome = "Moda"
                        },
                        new
                        {
                            ID = 5,
                            Ativo = true,
                            Descricao = "Livros",
                            Nome = "Livros"
                        });
                });

            modelBuilder.Entity("SimpressWeb.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Perecivel")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("tblProduto");
                });

            modelBuilder.Entity("SimpressWeb.Models.Produto", b =>
                {
                    b.HasOne("SimpressWeb.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
