using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TLWebApi.Data.Migrations
{
    public partial class AddTrailsVehiclesCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailCategoryId = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    LoadCapacity = table.Column<int>(type: "int", nullable: false),
                    AutoTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trails_AutoTypes_AutoTypeId",
                        column: x => x.AutoTypeId,
                        principalTable: "AutoTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trails_TrailCategories_TrailCategoryId",
                        column: x => x.TrailCategoryId,
                        principalTable: "TrailCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelConsumptionSummer = table.Column<double>(type: "float", nullable: false),
                    FuelConsumptionWinter = table.Column<double>(type: "float", nullable: false),
                    FuelTank = table.Column<int>(type: "int", nullable: false),
                    VehicleCategoryId = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    LoadCapacity = table.Column<int>(type: "int", nullable: false),
                    AutoTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_AutoTypes_AutoTypeId",
                        column: x => x.AutoTypeId,
                        principalTable: "AutoTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AutoTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Prelata" },
                    { 2, "Frigider" },
                    { 3, "Duba" }
                });

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Camion" },
                    { 2, "Cap tractor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trails_AutoTypeId",
                table: "Trails",
                column: "AutoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trails_TrailCategoryId",
                table: "Trails",
                column: "TrailCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AutoTypeId",
                table: "Vehicles",
                column: "AutoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleCategoryId",
                table: "Vehicles",
                column: "VehicleCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trails");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "TrailCategories");

            migrationBuilder.DropTable(
                name: "AutoTypes");

            migrationBuilder.DropTable(
                name: "VehicleCategories");
        }
    }
}
