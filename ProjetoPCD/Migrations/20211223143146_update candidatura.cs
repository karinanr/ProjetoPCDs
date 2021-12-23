using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPCD.Migrations
{
    public partial class updatecandidatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Candidaturaid_Candidatura",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Candidaturaid_Candidatura",
                table: "Usuarios",
                column: "Candidaturaid_Candidatura");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Candidatura_Candidaturaid_Candidatura",
                table: "Usuarios",
                column: "Candidaturaid_Candidatura",
                principalTable: "Candidatura",
                principalColumn: "id_Candidatura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Candidatura_Candidaturaid_Candidatura",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Candidaturaid_Candidatura",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Candidaturaid_Candidatura",
                table: "Usuarios");
        }
    }
}
