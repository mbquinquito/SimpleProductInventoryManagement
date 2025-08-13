using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleProductInventoryManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addprods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8122), "Fruit", "Banana", new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8126), "Fruit", "Grapes", 39.99m, 400, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8126) },
                    { 3, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8129), "Fruit", "Mango", 59.99m, 480, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8129) },
                    { 4, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8131), "Vegetable", "Carrots", 9.99m, 200, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8132) },
                    { 5, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8134), "Vegetable", "Onions", 1.99m, 500, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8135) },
                    { 6, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8137), "Fruit", "Pineapple", 39.99m, 60, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8137) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 8, 23, 334, DateTimeKind.Local).AddTicks(3165), "This is a sample product description.", "Sample Product", new DateTime(2025, 8, 11, 15, 8, 23, 334, DateTimeKind.Local).AddTicks(3166) });
        }
    }
}
