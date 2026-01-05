using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "912047fa-4f9d-4281-b323-21ee0bf6c18e", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDo4bp9jInIc3H/EwkE2EOokEAs/OdXkIdVVIboYDMM3+afZuXxDMBRjjxIAFcVV/A==", null, false, "edd4da57-96ff-4db4-9c39-a1c1624c0531", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6743), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6782), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6784), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6788), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6790), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6792), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6795), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6797), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6799), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6801), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6803), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6805), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6807), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6809), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6811), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6813), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6816), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6818), new DateTime(2026, 1, 5, 14, 12, 22, 662, DateTimeKind.Local).AddTicks(6818) });
        }
    }
}
