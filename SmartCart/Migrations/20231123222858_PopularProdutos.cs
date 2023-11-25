using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaID, ProdutoNome, ProdutoDescricaoCurta, ProdutoDescricaoCompleta, ProdutoMarca, ProdutoCor, ProdutoPraticaEsportiva, ProdutoMaterial, ProdutoPreco, ImgUrl, ImgThumbnaiUrl, ProdutoFavorito, ProdutoAtivo)" +
                "VALUES('1', 'Bola', 'Bola Nike Pitch', 'Prepare-se para marcar com a Bola de Futebol Nike Pitch. Ela tem gráficos de alto contraste para visibilidade durante o jogo e o treino, enquanto seu design durável oferece um voo verdadeiro direto do pé', 'NIKE', 'Branco-Amarelo', 'Futebol', '60% borracha, 15% poliuretano, 13% poliéster e 12% EVA', '155', 'https://drive.google.com/file/d/1qA6_egNv5JJS0yk68mMAgbM-7lXTjK2a/view?usp=drive_link', 'https://drive.google.com/file/d/1qA6_egNv5JJS0yk68mMAgbM-7lXTjK2a/view?usp=drive_link', '1', '1' )");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaID, ProdutoNome, ProdutoDescricaoCurta, ProdutoDescricaoCompleta, ProdutoMarca, ProdutoCor, ProdutoPraticaEsportiva, ProdutoMaterial, ProdutoPreco, ImgUrl, ImgThumbnaiUrl, ProdutoFavorito, ProdutoAtivo)" +
                "VALUES('1', 'Bola', 'Topper Slick Campo', 'Jogar Futubol ficou muito mais emocionante com a bola de Campo Slick 2020 Azul 5159 da Topeper', 'Topper', 'Branco-Azul', 'Futebol', 'Cloreto de Polivinilo PVC', '68.99', 'https://drive.google.com/file/d/10hoyl7MENurfDgZFP_GyPcYRsAcrznO7/view?usp=drive_link', 'https://drive.google.com/file/d/10hoyl7MENurfDgZFP_GyPcYRsAcrznO7/view?usp=drive_link', '1', '1' )");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaID, ProdutoNome, ProdutoDescricaoCurta, ProdutoDescricaoCompleta, ProdutoMarca, ProdutoCor, ProdutoPraticaEsportiva, ProdutoMaterial, ProdutoPreco, ImgUrl, ImgThumbnaiUrl, ProdutoFavorito, ProdutoAtivo)" +
                "VALUES('1', 'Bola', 'Basquete Spalding TF-50', 'Desenvolvida pela Spalding, essa Bola de Basquete texturizada oferece maior aderência para as mãos em todas as jogadas dentro ou fora das quadras. Com borracha, em sua composição, a Bola TF-50 garante resistência e durabilidade durante o seu uso.', 'Spalding', 'Laranja-preto', 'Basquete', 'Borracha', '98.99', 'https://drive.google.com/file/d/1Ea4ZBcARPDbbeGg6gDN6wgrLKzvMWe3H/view?usp=drive_link', 'https://drive.google.com/file/d/1Ea4ZBcARPDbbeGg6gDN6wgrLKzvMWe3H/view?usp=drive_link', '1', '1' )");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaID, ProdutoNome, ProdutoDescricaoCurta, ProdutoDescricaoCompleta, ProdutoMarca, ProdutoCor, ProdutoPraticaEsportiva, ProdutoMaterial, ProdutoPreco, ImgUrl, ImgThumbnaiUrl, ProdutoFavorito, ProdutoAtivo)" +
                "VALUES('1', 'Bola', 'WILSON NBA DRV', 'Marrom, tamanho 17,78 - 74,90 cm\r\nWilson é a bola de basquete oficial da NBA. Esta bola apresenta a marca oficial da NBA juntamente com o icônico script Wilson\r\nCapa externa projetada para aderência em superfícies ásperas', 'WILSON NBA', 'Marrom', 'Basquete', 'Borracha', '134.99', 'https://drive.google.com/file/d/1OBGcvEhtKPh4sytGEFxMmFaFVbUq10JN/view?usp=drive_link', 'https://drive.google.com/file/d/1OBGcvEhtKPh4sytGEFxMmFaFVbUq10JN/view?usp=drive_link', '1', '1' )");
        }

        //~/imagens/Bola Topper.jpg
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}