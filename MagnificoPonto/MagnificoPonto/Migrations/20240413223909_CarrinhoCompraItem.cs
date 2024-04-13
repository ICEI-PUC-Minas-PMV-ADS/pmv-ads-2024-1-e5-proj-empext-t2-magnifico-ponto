using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagnificoPonto.Migrations
{
    public partial class CarrinhoCompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmigurumiId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Amigurumis_AmigurumiId",
                        column: x => x.AmigurumiId,
                        principalTable: "Amigurumis",
                        principalColumn: "AmigurumiId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_AmigurumiId",
                table: "CarrinhoCompraItens",
                column: "AmigurumiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");
        }
    }
}
