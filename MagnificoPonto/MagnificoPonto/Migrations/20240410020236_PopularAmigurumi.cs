using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagnificoPonto.Migrations
{
    public partial class PopularAmigurumi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Amigurumis (Nome, Descricao, Preco, Tamanho, TempoConfec, Cor, ImagemUrl, ImagemThumbnailUrl, Personalizacao, AmigurumiLancamento, EmEstoque, CategoriaId)" +
                "VALUES ('Leão', 'Rei da Floresta!!', '50.00', '23 cm', '8', 'Amarelo', 'https://amigurumi.ateliedeartesanato.com.br/wp-content/uploads/2021/12/123-Leao-de-Amigurumi-Leao-de-croche-1024x1024.jpg', 'https://static.wixstatic.com/media/2cead2_6fe52fa7ff2d4e81b305d734a1e732dd~mv2.jpeg/v1/fill/w_500,h_500,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/2cead2_6fe52fa7ff2d4e81b305d734a1e732dd~mv2.jpeg', '', 1, 1, 5)");

            migrationBuilder.Sql("INSERT INTO Amigurumis (Nome, Descricao, Preco, Tamanho, TempoConfec, Cor, ImagemUrl, ImagemThumbnailUrl, Personalizacao, AmigurumiLancamento, EmEstoque, CategoriaId)" +
                "VALUES ('Peppa', 'A porquinha Peppa, sua família e amigos exploram o mundo à sua volta.', '125.00', '30 cm', '10', 'Rosa', 'https://i.pinimg.com/736x/b4/6d/d5/b46dd53821fbca5c58238c8ff6dc10fd.jpg', 'https://down-br.img.susercontent.com/file/br-11134207-23030-wkxs11u1moov4b', '', 0, 0, 6)");

            migrationBuilder.Sql("INSERT INTO Amigurumis (Nome, Descricao, Preco, Tamanho, TempoConfec, Cor, ImagemUrl, ImagemThumbnailUrl, Personalizacao, AmigurumiLancamento, EmEstoque, CategoriaId)" +
                "VALUES ('Menino', 'Amigurumi menino', '250.50', '34 cm', '12', 'Azul', 'https://lamucaatelie.com.br/wp-content/uploads/2022/06/foto1-menino-biel-600x600.png.webp', 'https://img.elo7.com.br/product/360x360/4BF4AEB/menino-amigurumi-receita-amigurumi.jpg', '', 0, 1, 7)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Amigurumis");
        }
    }
}
