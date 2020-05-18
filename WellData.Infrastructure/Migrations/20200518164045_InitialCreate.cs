using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellData.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "1", 0, "f266dab1-dc74-4044-a73b-3cf914975495", "User", null, false, false, null, null, null, null, null, false, "5ee5d3dc-4381-4539-99dd-d92c8c3bb596", false, null, "John", "Doe" });

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
                values: new object[] { 1, 183, 3421 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation" },
                values: new object[] { 2, 2140, 3221 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation" },
                values: new object[] { 3, 3789, 3321 });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Flows");

            migrationBuilder.DropTable(
                name: "WaterLevels");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropTable(
                name: "Wells");
        }
    }
}
