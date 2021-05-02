using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpressWeb.Migrations
{
    public partial class DefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblCategoriaProduto",
                columns: new[] { "ID", "Ativo", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Eletrodomésticos", "Eletrônico" },
                    { 2, true, "Produtos para Informática", "Informática" },
                    { 3, true, "Aparelhos e acessórios", "Celulares" },
                    { 4, true, "Artigos para vestuário em geral", "Moda" },
                    { 5, true, "Livros", "Livros" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblCategoriaProduto",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblCategoriaProduto",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblCategoriaProduto",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblCategoriaProduto",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblCategoriaProduto",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
