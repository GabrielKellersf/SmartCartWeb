using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CatergoriaNome, CategoriaDescricao)" +
                "VALUES('Bola', 'Bolas esportivas de futebol, basquete, volei, tênis e etc')");

            migrationBuilder.Sql("INSERT INTO Categorias(CatergoriaNome, CategoriaDescricao)" +
                "VALUES('Adereços', 'Adereços Esportivos de futebol, basquete, volei, tênis e etc')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}