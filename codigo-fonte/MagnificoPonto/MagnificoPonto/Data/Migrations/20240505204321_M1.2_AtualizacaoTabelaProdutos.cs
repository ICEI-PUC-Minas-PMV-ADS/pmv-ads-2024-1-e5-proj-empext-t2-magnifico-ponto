using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagnificoPonto.Data.Migrations
{
    public partial class M12_AtualizacaoTabelaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Referencia",
                table: "Cadastro de Produtos");

            migrationBuilder.AddColumn<double>(
                name: "Peso",
                table: "Cadastro de Produtos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Cadastro de Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Cadastro de Produtos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Cadastro de Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Referencia",
                table: "Cadastro de Produtos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
