using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstApp.Migrations
{
    public partial class Correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Book",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "autor",
                table: "Book",
                newName: "Autor");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Book",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Book",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "Book",
                newName: "autor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "id");
        }
    }
}
