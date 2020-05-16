using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellData.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DistrictNumber = table.Column<int>(nullable: false),
                    Elevation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WellId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    UnitTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flows_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flows_Wells_WellId",
                        column: x => x.WellId,
                        principalTable: "Wells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WellId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DepthToWater = table.Column<double>(nullable: false),
                    UnitTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterLevels_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterLevels_Wells_WellId",
                        column: x => x.WellId,
                        principalTable: "Wells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Id", "Abbreviation", "DisplayName" },
                values: new object[] { 1, "GPM", "Gallons Per Minute" });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Id", "Abbreviation", "DisplayName" },
                values: new object[] { 2, "ft", "Feet" });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation" },
                values: new object[] { 1, 1, 3421 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation" },
                values: new object[] { 2, 2, 3221 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation" },
                values: new object[] { 3, 3, 3321 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 1, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 234.22999999999999, 1, 1 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 2, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 214.22999999999999, 1, 1 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 3, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 274.23000000000002, 1, 2 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 4, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 224.22999999999999, 1, 2 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 5, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 214.22999999999999, 1, 3 });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "Id", "Date", "Rate", "UnitTypeId", "WellId" },
                values: new object[] { 6, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 199.22999999999999, 1, 3 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 1, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 234.22999999999999, 2, 1 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 2, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 214.22999999999999, 2, 1 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 3, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 274.23000000000002, 2, 2 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 4, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 224.22999999999999, 2, 2 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 5, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 214.22999999999999, 2, 3 });

            migrationBuilder.InsertData(
                table: "WaterLevels",
                columns: new[] { "Id", "Date", "DepthToWater", "UnitTypeId", "WellId" },
                values: new object[] { 6, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 199.22999999999999, 2, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Flows_UnitTypeId",
                table: "Flows",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Flows_WellId",
                table: "Flows",
                column: "WellId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterLevels_UnitTypeId",
                table: "WaterLevels",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterLevels_WellId",
                table: "WaterLevels",
                column: "WellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flows");

            migrationBuilder.DropTable(
                name: "WaterLevels");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropTable(
                name: "Wells");
        }
    }
}
