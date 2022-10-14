using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TLWebApi.Migrations
{
    public partial class AddVehicleExpirstions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CertAgrExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCVerdeExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCascoExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCemtExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertRcaExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertStingExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ItpExpDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertAgrExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCVerdeExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCascoExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertCemtExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertRcaExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertStingExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ItpExpDate",
                table: "Trails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertAgrExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertCVerdeExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertCascoExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertCemtExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertRcaExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertStingExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "ItpExpDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CertAgrExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "CertCVerdeExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "CertCascoExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "CertCemtExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "CertRcaExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "CertStingExpDate",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "ItpExpDate",
                table: "Trails");
        }
    }
}
