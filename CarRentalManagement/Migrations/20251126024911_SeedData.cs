using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicle",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Model",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Make",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customer",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Colour",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Booking",
                newName: "DateUpdated");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(4219), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(4248), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(4254), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(4255), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5152), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5156), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(4999), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5004), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5008), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5009), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5012), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5013), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5015), new DateTime(2025, 11, 26, 10, 49, 10, 438, DateTimeKind.Local).AddTicks(5016), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicle",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Model",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Make",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customer",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colour",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Booking",
                newName: "DataUpdated");
        }
    }
}
