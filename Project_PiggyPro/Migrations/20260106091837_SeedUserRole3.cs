using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f6886b93-88a3-4594-83f3-12b02c40f72d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOvHMy4Hc9CcmTbPx6wxt6eese3sQEadOJHTtS8ZbI+15mplbgdMgj4vcL7F/n4Cxw==", null, false, "1231103e-88d7-4592-8496-5556ba8eca33", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5634), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5666), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5668), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5670), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5672), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5676), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5678), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5680), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5682), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5686), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5690), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5694), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5737), new DateTime(2026, 1, 6, 17, 18, 36, 824, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1110), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1166), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1172), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1176), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1180), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1185), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1189), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1193), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1198), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1332), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1337), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1341), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1345), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1350), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1354), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1359), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1363), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1368), new DateTime(2026, 1, 6, 17, 17, 17, 841, DateTimeKind.Local).AddTicks(1369) });
        }
    }
}
