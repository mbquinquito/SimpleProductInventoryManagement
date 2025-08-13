using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProductInventoryManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 26, 34, 888, DateTimeKind.Local).AddTicks(696), new DateTime(2025, 8, 8, 15, 26, 34, 888, DateTimeKind.Local).AddTicks(696) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 7, 16, 59, 15, 495, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 8, 7, 16, 59, 15, 495, DateTimeKind.Local).AddTicks(2657) });
        }
    }
}
