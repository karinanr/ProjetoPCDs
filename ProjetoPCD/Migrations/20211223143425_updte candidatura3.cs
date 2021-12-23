using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPCD.Migrations
{
    public partial class updtecandidatura3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCandidatura",
                table: "Candidatura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCandidatura",
                table: "Candidatura");
        }
    }
}
