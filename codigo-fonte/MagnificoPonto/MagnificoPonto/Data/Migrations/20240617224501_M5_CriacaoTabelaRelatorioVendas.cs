using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagnificoPonto.Data.Migrations
{
    public partial class M5_CriacaoTabelaRelatorioVendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelatorioVendas",
                columns: table => new
                {
                    RelatorioVendasModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlataformaVenda = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Criacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amigurumi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TempoConfeccao = table.Column<int>(type: "int", nullable: false),
                    Personalizacao = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioVendas", x => x.RelatorioVendasModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatorioVendas");
        }
    }
}
