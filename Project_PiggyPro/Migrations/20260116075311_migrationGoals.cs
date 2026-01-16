using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_PiggyPro.Migrations
{
    /// <inheritdoc />
    public partial class migrationGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalStatus",
                table: "Goal");

            migrationBuilder.AlterColumn<string>(
                name: "GoalName",
                table: "Goal",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Goal",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Goal",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Goal",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Goal",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d9f63a-2e5b-43ed-a46e-d5d1b407b6f3", new DateTime(2026, 1, 16, 7, 53, 10, 266, DateTimeKind.Utc).AddTicks(9082), "AQAAAAIAAYagAAAAEHEZP/mk6xREPpPxm+qgCopFohEyqRdcOwNx5KAIAEirZKsjYUfEIJLvtdj8f6vo8w==", "6b438d39-3981-4835-9a07-6ee364967633" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8724), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8736), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8738), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8740), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8742), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8743), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8745), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8746), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8748), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8749), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8751), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8753), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8754), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8758), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8759), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8761), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8762), new DateTime(2026, 1, 16, 15, 53, 10, 266, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.CreateIndex(
                name: "IX_Goal_AppUserId",
                table: "Goal",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_AspNetUsers_AppUserId",
                table: "Goal",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_AspNetUsers_AppUserId",
                table: "Goal");

            migrationBuilder.DropIndex(
                name: "IX_Goal_AppUserId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Goal");

            migrationBuilder.AlterColumn<string>(
                name: "GoalName",
                table: "Goal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Goal",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "GoalStatus",
                table: "Goal",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
