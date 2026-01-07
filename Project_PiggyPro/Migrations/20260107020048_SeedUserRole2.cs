using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
<<<<<<< HEAD
=======
            

>>>>>>> just edit.
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d7a980-b215-4607-a640-2920ecd57ee3", "AQAAAAIAAYagAAAAEG2pdmL066VX3q8FqdzcMEHt4MOobhF3a/3JwVSIJ7Q9i6yxrv3v1OIVR/t0Sm9arA==", "66d9a487-59d1-4388-85da-7fa028316d2e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8251), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8265), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8267), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8269), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8271), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8272), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8274), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8275), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8277), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8279), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8280), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8282), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8283), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8285), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8287), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8288), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8290), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8291), new DateTime(2026, 1, 7, 10, 0, 47, 19, DateTimeKind.Local).AddTicks(8292) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "912047fa-4f9d-4281-b323-21ee0bf6c18e", "AQAAAAIAAYagAAAAEDo4bp9jInIc3H/EwkE2EOokEAs/OdXkIdVVIboYDMM3+afZuXxDMBRjjxIAFcVV/A==", "edd4da57-96ff-4db4-9c39-a1c1624c0531" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1066), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1084), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1088), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1090), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1093), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1096), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1099), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1102), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1104), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1107), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1110), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1113), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1116), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1119), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1122), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1125), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1128), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1131), new DateTime(2026, 1, 5, 14, 34, 1, 471, DateTimeKind.Local).AddTicks(1131) });
        }
    }
}
