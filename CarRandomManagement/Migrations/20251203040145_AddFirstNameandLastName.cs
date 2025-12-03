using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRandomManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstNameandLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(5664), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(5692), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6423), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6430), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6200), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6206), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 12, 3, 12, 1, 43, 687, DateTimeKind.Local).AddTicks(6215) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5544), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5918), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5920), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5788), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5790), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5793), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5795), new DateTime(2025, 11, 26, 11, 55, 37, 242, DateTimeKind.Local).AddTicks(5796) });
        }
    }
}
