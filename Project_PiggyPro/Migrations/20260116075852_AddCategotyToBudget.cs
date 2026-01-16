using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class AddCategotyToBudget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d95127a-857c-4d1e-b443-32474406ef39", new DateTime(2026, 1, 16, 7, 58, 51, 71, DateTimeKind.Utc).AddTicks(7193), "AQAAAAIAAYagAAAAEPeFABql8mLZAVbgdX70hOcqAbWGuQcf5mQUStS6VCpldPXIJoLmKFlwmP9IVC0B/Q==", "3ec3e10a-ec95-40fe-8495-580017ab5833" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6740), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6758), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6760), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6762), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6764), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6766), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6768), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6770), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6772), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6775), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6776), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6778), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6780), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6782), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6784), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6786), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6788), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6790), new DateTime(2026, 1, 16, 15, 58, 51, 71, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.CreateIndex(
                name: "IX_Budget_CategoryId",
                table: "Budget",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_Category_CategoryId",
                table: "Budget",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_Category_CategoryId",
                table: "Budget");

            migrationBuilder.DropIndex(
                name: "IX_Budget_CategoryId",
                table: "Budget");

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
    }
}
