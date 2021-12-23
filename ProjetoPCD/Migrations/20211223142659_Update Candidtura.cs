using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPCD.Migrations
{
    public partial class UpdateCandidtura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeCurso",
                table: "Candidatura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresa",
                table: "Candidatura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Candidatura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeVaga",
                table: "Candidatura",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCurso",
                table: "Candidatura");

            migrationBuilder.DropColumn(
                name: "NomeEmpresa",
                table: "Candidatura");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Candidatura");

            migrationBuilder.DropColumn(
                name: "NomeVaga",
                table: "Candidatura");
        }
    }
}
