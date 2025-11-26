using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRandomManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 177, DateTimeKind.Local).AddTicks(9999), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(22), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(307), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(310), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(241), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(243), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 11, 26, 11, 37, 28, 178, DateTimeKind.Local).AddTicks(245) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1695), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1966), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1968), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1871), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1873), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1874), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1876), new DateTime(2025, 11, 24, 16, 12, 32, 45, DateTimeKind.Local).AddTicks(1877) });
        }
    }
}
