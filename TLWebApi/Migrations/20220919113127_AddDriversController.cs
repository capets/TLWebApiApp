using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TLWebApi.Migrations
{
    public partial class AddDriversController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TahoExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MedExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NationalExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportExpDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
