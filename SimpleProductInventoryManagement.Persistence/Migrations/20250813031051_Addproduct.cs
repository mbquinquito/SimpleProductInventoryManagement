using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProductInventoryManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2646), new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2650), new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2658), new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2661), new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2653), "Fruit", "Pineapple", 69.99m, 900, new DateTime(2025, 8, 13, 11, 10, 51, 315, DateTimeKind.Local).AddTicks(2653) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7157), new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7159) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7170), new DateTime(2025, 8, 13, 11, 9, 17, 681, DateTimeKind.Local).AddTicks(7171) });
        }
    }
}
