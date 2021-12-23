using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPCD.Migrations
{
    public partial class criacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    id_Curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.id_Curso);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    id_Empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamoDeAtividade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parceira = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.id_Empresa);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    id_Vaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresaid_Empresa = table.Column<int>(type: "int", nullable: true),
                    Benefícios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargaHoraria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.id_Vaga);
                    table.ForeignKey(
                        name: "FK_Vagas_Empresas_Empresaid_Empresa",
                        column: x => x.Empresaid_Empresa,
                        principalTable: "Empresas",
                        principalColumn: "id_Empresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidatura",
                columns: table => new
                {
                    id_Candidatura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresaid_Empresa = table.Column<int>(type: "int", nullable: true),
                    Cursoid_Curso = table.Column<int>(type: "int", nullable: true),
                    Vagaid_Vaga = table.Column<int>(type: "int", nullable: true),
                    Usuarioid_Usuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatura", x => x.id_Candidatura);
                    table.ForeignKey(
                        name: "FK_Candidatura_Curso_Cursoid_Curso",
                        column: x => x.Cursoid_Curso,
                        principalTable: "Curso",
                        principalColumn: "id_Curso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Empresas_Empresaid_Empresa",
                        column: x => x.Empresaid_Empresa,
                        principalTable: "Empresas",
                        principalColumn: "id_Empresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Usuarios_Usuarioid_Usuario",
                        column: x => x.Usuarioid_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_Usuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Vagas_Vagaid_Vaga",
                        column: x => x.Vagaid_Vaga,
                        principalTable: "Vagas",
                        principalColumn: "id_Vaga",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_Cursoid_Curso",
                table: "Candidatura",
                column: "Cursoid_Curso");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_Empresaid_Empresa",
                table: "Candidatura",
                column: "Empresaid_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_Usuarioid_Usuario",
                table: "Candidatura",
                column: "Usuarioid_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_Vagaid_Vaga",
                table: "Candidatura",
                column: "Vagaid_Vaga");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_Empresaid_Empresa",
                table: "Vagas",
                column: "Empresaid_Empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatura");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
