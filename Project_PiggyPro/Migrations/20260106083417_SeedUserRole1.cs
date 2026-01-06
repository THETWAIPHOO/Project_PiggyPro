using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole1 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(747), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(763), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(765), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(766), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(768), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(769), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(771), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(772), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(774), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(775), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(777), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(778), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(780), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(782), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(783), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(785), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(819), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(820), new DateTime(2026, 1, 6, 2, 55, 33, 950, DateTimeKind.Local).AddTicks(820) });
        }
    }
}
