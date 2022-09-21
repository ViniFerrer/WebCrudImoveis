using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCrudImoveis.Migrations
{
    public partial class testemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Imoveis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Imoveis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Imoveis",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Imoveis");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Imoveis");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Imoveis");
        }
    }
}
