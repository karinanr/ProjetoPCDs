using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPCD.Migrations
{
    public partial class corrigindo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatura_Curso_Cursoid_Curso",
                table: "Candidatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Curso",
                table: "Curso");

            migrationBuilder.RenameTable(
                name: "Curso",
                newName: "Cursos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "id_Curso");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatura_Cursos_Cursoid_Curso",
                table: "Candidatura",
                column: "Cursoid_Curso",
                principalTable: "Cursos",
                principalColumn: "id_Curso",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatura_Cursos_Cursoid_Curso",
                table: "Candidatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "Curso");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Curso",
                table: "Curso",
                column: "id_Curso");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatura_Curso_Cursoid_Curso",
                table: "Candidatura",
                column: "Cursoid_Curso",
                principalTable: "Curso",
                principalColumn: "id_Curso",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
