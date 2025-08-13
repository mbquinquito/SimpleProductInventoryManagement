using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProductInventoryManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 8, 7, 16, 59, 15, 495, DateTimeKind.Local).AddTicks(2656), "This is a sample product description.", "Sample Product", 19.99m, 100, new DateTime(2025, 8, 7, 16, 59, 15, 495, DateTimeKind.Local).AddTicks(2657) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
