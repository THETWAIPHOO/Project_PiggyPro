using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0f8b44-5e8c-48d9-8357-bf3e2f98f6b8", new DateTime(2026, 1, 18, 12, 51, 44, 80, DateTimeKind.Utc).AddTicks(9739), "AQAAAAIAAYagAAAAEIndwUlMXxffrnEsRsV/BHn7DFnSLti0BwmQpvp8qUQI2/83SGwgTRW7szufI/ipuA==", "50be5308-d761-4029-a000-4099e67c0e2e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9138), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9152), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9154), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9156), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9157), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9159), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9161), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9162), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9164), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9165), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9167), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9168), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryName", "CategoryType", "DateCreated", "DateUpdated" },
                values: new object[] { "Savings Goal", "Savings", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9170), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryName", "CategoryType", "DateCreated", "DateUpdated" },
                values: new object[] { "Other Expenses", "Expense", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9172), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Salary", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9173), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Freelance", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9175), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Investment Income", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9176), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Gift/Bonus", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9178), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "AppUserId", "CategoryName", "CategoryType", "CreatedBy", "DateCreated", "DateUpdated", "IsSystemCategory", "UpdatedBy" },
                values: new object[] { 19, null, "Other Income", "Income", "System", new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9179), new DateTime(2026, 1, 18, 20, 51, 44, 80, DateTimeKind.Local).AddTicks(9180), true, "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14a5e980-54fc-4733-8373-9297b2007e3c", new DateTime(2026, 1, 18, 12, 38, 46, 261, DateTimeKind.Utc).AddTicks(1390), "AQAAAAIAAYagAAAAEGZI+r9TbQwt/GwZC5tr4hNt0QjWSIfcVqld4uyISXDNtNIzz1X84Qn/rGt/EspV9w==", "a9ad5f1b-a1a8-4d95-87a1-b423e78cbf83" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1037), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1050), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1052), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1054), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1055), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1057), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1059), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1060), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1062), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1063), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1065), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1067), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryName", "CategoryType", "DateCreated", "DateUpdated" },
                values: new object[] { "Other Expenses", "Expense", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1068), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryName", "CategoryType", "DateCreated", "DateUpdated" },
                values: new object[] { "Salary", "Income", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1070), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Freelance", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1071), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Investment Income", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1073), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Gift/Bonus", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1074), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Other Income", new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1076), new DateTime(2026, 1, 18, 20, 38, 46, 261, DateTimeKind.Local).AddTicks(1076) });
        }
    }
}
