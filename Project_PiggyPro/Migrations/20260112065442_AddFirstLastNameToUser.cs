using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstLastNameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7a1bc25-268b-46b3-932e-4ce74731fb6f", new DateTime(2026, 1, 12, 5, 36, 15, 388, DateTimeKind.Utc).AddTicks(532), "AQAAAAIAAYagAAAAEJ/mukmbruU/jF7Nkcsg2hgu2O3Bpre6jNLUrk/zptEDr7al4ES602TgFz3moO6FTg==", "96821fd6-52b2-41ea-9f8c-c56fea762df0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9733), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9761), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9765), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9769), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9773), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9777), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9780), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9784), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9787), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9791), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9795), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9798), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9802), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9806), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9809), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9813), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9817), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9821), new DateTime(2026, 1, 12, 13, 36, 15, 387, DateTimeKind.Local).AddTicks(9822) });
        }
    }
}
