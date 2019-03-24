using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Repository.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DIVISION",
                table: "DIVISION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPANY",
                table: "COMPANY");

            migrationBuilder.RenameTable(
                name: "DIVISION",
                newName: "Division");

            migrationBuilder.RenameTable(
                name: "COMPANY",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Division",
                table: "Division",
                column: "INITIAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "INITIAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Division",
                table: "Division");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Division",
                newName: "DIVISION");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "COMPANY");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DIVISION",
                table: "DIVISION",
                column: "INITIAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPANY",
                table: "COMPANY",
                column: "INITIAL");
        }
    }
}
