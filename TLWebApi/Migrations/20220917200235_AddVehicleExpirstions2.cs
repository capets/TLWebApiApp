using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TLWebApi.Migrations
{
    public partial class AddVehicleExpirstions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CertTahoExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertTahoExpDate",
                table: "Trucks");
        }
    }
}
