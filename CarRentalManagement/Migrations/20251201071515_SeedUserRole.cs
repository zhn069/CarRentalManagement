using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 404, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 12, 1, 15, 15, 14, 404, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 404, DateTimeKind.Local).AddTicks(7090), new DateTime(2025, 12, 1, 15, 15, 14, 404, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 410, DateTimeKind.Local).AddTicks(701), new DateTime(2025, 12, 1, 15, 15, 14, 410, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 410, DateTimeKind.Local).AddTicks(711), new DateTime(2025, 12, 1, 15, 15, 14, 410, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6807), new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6861), new DateTime(2025, 12, 1, 15, 15, 14, 407, DateTimeKind.Local).AddTicks(6862) });
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
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 801, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 12, 1, 14, 53, 51, 801, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 801, DateTimeKind.Local).AddTicks(7135), new DateTime(2025, 12, 1, 14, 53, 51, 801, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 806, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 12, 1, 14, 53, 51, 806, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 806, DateTimeKind.Local).AddTicks(4520), new DateTime(2025, 12, 1, 14, 53, 51, 806, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1536), new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1547), new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1632), new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1635), new DateTime(2025, 12, 1, 14, 53, 51, 804, DateTimeKind.Local).AddTicks(1636) });
        }
    }
}
