using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Repository.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    INITIAL = table.Column<string>(nullable: false),
                    NAME = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    TELA = table.Column<string>(nullable: true),
                    FAX = table.Column<string>(nullable: true),
                    VAT = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    WEBSITE = table.Column<string>(nullable: true),
                    FBDATE = table.Column<DateTime>(nullable: false),
                    FEDATE = table.Column<DateTime>(nullable: false),
                    FBDATE_BS = table.Column<string>(nullable: true),
                    FEDATE_BS = table.Column<string>(nullable: true),
                    ISBRANCH = table.Column<int>(nullable: false),
                    ID = table.Column<string>(nullable: true),
                    ACID = table.Column<string>(nullable: true),
                    PhiscalID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.INITIAL);
                });

            migrationBuilder.CreateTable(
                name: "DIVISION",
                columns: table => new
                {
                    INITIAL = table.Column<string>(nullable: false),
                    NAME = table.Column<string>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    MAIN = table.Column<int>(nullable: false),
                    COMNAME = table.Column<string>(nullable: true),
                    COMADD = table.Column<string>(nullable: true),
                    COMID = table.Column<string>(nullable: true),
                    ACID = table.Column<string>(nullable: true),
                    ID = table.Column<string>(nullable: true),
                    MSG1 = table.Column<string>(nullable: true),
                    MSG2 = table.Column<string>(nullable: true),
                    MSG3 = table.Column<string>(nullable: true),
                    RateGroupID = table.Column<int>(nullable: false),
                    TYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIVISION", x => x.INITIAL);
                });

            migrationBuilder.CreateTable(
                name: "MasterCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NAME = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    TELA = table.Column<string>(nullable: true),
                    FAX = table.Column<string>(nullable: true),
                    VAT = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    WEBSITE = table.Column<string>(nullable: true),
                    FBDATE = table.Column<DateTime>(nullable: false),
                    FEDATE = table.Column<DateTime>(nullable: false),
                    FBDATE_BS = table.Column<string>(nullable: true),
                    FEDATE_BS = table.Column<string>(nullable: true),
                    ISBRANCH = table.Column<int>(nullable: false),
                    ACID = table.Column<string>(nullable: true),
                    PhiscalID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCompany", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMPANY");

            migrationBuilder.DropTable(
                name: "DIVISION");

            migrationBuilder.DropTable(
                name: "MasterCompany");
        }
    }
}
