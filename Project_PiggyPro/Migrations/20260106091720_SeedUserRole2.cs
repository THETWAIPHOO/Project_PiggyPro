using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2381), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2406), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2410), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2413), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2415), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2418), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2421), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2424), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2427), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2430), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2432), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2435), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2438), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2441), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2447), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2449), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2452), new DateTime(2026, 1, 6, 16, 34, 14, 982, DateTimeKind.Local).AddTicks(2453) });
        }
    }
}
