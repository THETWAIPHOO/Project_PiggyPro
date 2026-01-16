using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class AddBucketTypeAndAllocatedAmountToBudget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AllocatedAmount",
                table: "Budget",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "BucketType",
                table: "Budget",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1873acd4-9fa5-4c2e-abb5-e88a9733f720", new DateTime(2026, 1, 14, 8, 11, 52, 318, DateTimeKind.Utc).AddTicks(6503), "AQAAAAIAAYagAAAAEENEPJxvoBQjklgWnXDrivgvvUOXJiaG5t3NCbk+UmoDV3V1f2YZalmBAscYXwDppQ==", "020ff8c9-ab5b-4bf1-a9c4-149d7f313799" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5020), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5071), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5076), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5081), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5086), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5090), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5095), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5099), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5104), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5108), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5117), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5126), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5130), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5135), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5139), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5143), new DateTime(2026, 1, 14, 16, 11, 52, 318, DateTimeKind.Local).AddTicks(5144) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllocatedAmount",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "BucketType",
                table: "Budget");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fdcc62c-6845-4697-887d-5be13312f972", new DateTime(2026, 1, 12, 6, 54, 42, 81, DateTimeKind.Utc).AddTicks(4929), "AQAAAAIAAYagAAAAEK+Vv29AIVnpbq0sSZyccH9k5kSZtkJ1z0nIUzORikHTOKzY9tiiRdvxGwiyVZvGhQ==", "720b3e5f-7f50-440f-935f-b27f5b37addd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4359), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4385), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4387), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4388), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4390), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4392), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4393), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4395), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4397), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4399), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4400), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4402), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4404), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4405), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4407), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4409), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4411), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4412), new DateTime(2026, 1, 12, 14, 54, 42, 81, DateTimeKind.Local).AddTicks(4413) });
        }
    }
}
