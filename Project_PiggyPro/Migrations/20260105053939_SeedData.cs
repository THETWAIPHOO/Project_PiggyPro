using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Category");

            migrationBuilder.AddColumn<bool>(
                name: "IsSystemCategory",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CategoryType", "CreatedBy", "DateCreated", "DateUpdated", "IsSystemCategory", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Housing & Rent", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7336), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7363), true, "System" },
                    { 2, "Groceries", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7366), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7367), true, "System" },
                    { 3, "Utilities", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7369), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7370), true, "System" },
                    { 4, "Transportation", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7372), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7373), true, "System" },
                    { 5, "Healthcare", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7375), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7376), true, "System" },
                    { 6, "Dining Out", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7378), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7379), true, "System" },
                    { 7, "Entertainment", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7381), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7382), true, "System" },
                    { 8, "Shopping", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7384), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7385), true, "System" },
                    { 9, "Hobbies", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7387), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7388), true, "System" },
                    { 10, "Savings", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7390), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7391), true, "System" },
                    { 11, "Investments", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7393), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7394), true, "System" },
                    { 12, "Emergency Fund", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7396), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7397), true, "System" },
                    { 13, "Other Expenses", "Expense", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7400), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7400), true, "System" },
                    { 14, "Salary", "Income", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7403), true, "System" },
                    { 15, "Freelance", "Income", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7405), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7406), true, "System" },
                    { 16, "Investment Income", "Income", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7408), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7409), true, "System" },
                    { 17, "Gift/Bonus", "Income", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7411), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7412), true, "System" },
                    { 18, "Other Income", "Income", "System", new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7414), new DateTime(2026, 1, 5, 13, 39, 37, 582, DateTimeKind.Local).AddTicks(7415), true, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "IsSystemCategory",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
