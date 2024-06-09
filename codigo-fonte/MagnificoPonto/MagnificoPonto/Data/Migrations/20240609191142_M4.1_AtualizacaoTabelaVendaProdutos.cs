using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagnificoPonto.Data.Migrations
{
    public partial class M41_AtualizacaoTabelaVendaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "VendaProdutos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "VendaProdutos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "VendaProdutos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Tamanho",
                table: "VendaProdutos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "VendaProdutos");
        }
    }
}
