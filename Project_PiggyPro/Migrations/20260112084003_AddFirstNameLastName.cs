using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstNameLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fed412e0-c66d-45ad-8c4d-cf59b842bd4a", new DateTime(2026, 1, 12, 8, 40, 2, 371, DateTimeKind.Utc).AddTicks(2239), "AQAAAAIAAYagAAAAEASqO9IrDTNk0s1NCGCUhW5IKdZ+a/4Rt2/RLyFpHUFcVpV469p+s/4qmakuKtFgGA==", "1e39f288-4920-429b-8234-8a0235961587" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1885), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1898), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1900), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1901), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1903), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1904), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1906), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1908), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1909), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1911), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1912), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1914), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1916), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1917), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1919), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1920), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1922), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1923), new DateTime(2026, 1, 12, 16, 40, 2, 371, DateTimeKind.Local).AddTicks(1924) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c727ca6-9520-42b7-be09-e3ea3028939f", new DateTime(2026, 1, 12, 7, 14, 28, 509, DateTimeKind.Utc).AddTicks(6248), "AQAAAAIAAYagAAAAEOtA0Kbhxn+JS8TmXeA+FldLwbxyh9bVmp7TQn9nhkHaecm9n2apQ1enSF9RPvXrYw==", "8d5d481c-1520-4eff-8214-1939462840b9" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5834), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5849), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5851), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5853), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5854), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5856), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5858), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5859), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5861), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5863), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5865), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5866), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5868), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5870), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5871), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5873), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5875), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5876), new DateTime(2026, 1, 12, 15, 14, 28, 509, DateTimeKind.Local).AddTicks(5877) });
        }
    }
}
