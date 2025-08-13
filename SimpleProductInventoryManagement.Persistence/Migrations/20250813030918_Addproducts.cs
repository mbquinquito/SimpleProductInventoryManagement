using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProductInventoryManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7157), "Dragonfruit", new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7165), new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7170), "Mango", 59.99m, 480, new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7171) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8122), "Banana", new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8126), new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8131), new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8134), new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8137), "Pineapple", 39.99m, 60, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8129), "Fruit", "Mango", 59.99m, 480, new DateTime(2025, 8, 13, 11, 7, 42, 91, DateTimeKind.Local).AddTicks(8129) });
        }
    }
}
