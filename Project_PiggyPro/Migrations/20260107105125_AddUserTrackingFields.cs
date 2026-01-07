using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTrackingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8366f3e8-b608-4874-ab39-159826ae5669", new DateTime(2026, 1, 7, 10, 51, 24, 387, DateTimeKind.Utc).AddTicks(6280), null, "AQAAAAIAAYagAAAAEKZpaXREeC2bMc3WwOjapIievdj95g5kmm3dbFCALjCFOlCGbKlMS4yDxIj6n9BkPg==", "53a25a4c-3950-4409-8863-9dd718d0681b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5928), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5943), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5945), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5947), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5951), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5952), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5954), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5956), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5957), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5959), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5960), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5962), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5964), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5965), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5967), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5970), new DateTime(2026, 1, 7, 18, 51, 24, 387, DateTimeKind.Local).AddTicks(5970) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "AspNetUsers");

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
    }
}
