using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "Address 1", "colombo 1", "Street 1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "Address 2", "colombo 2", "Street 2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "Address 3", "colombo 3", "Street 3" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 1, 11, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9775), new DateTime(2024, 1, 11, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 1, 11, 6, 22, 18, 594, DateTimeKind.Local).AddTicks(9779) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(628) });
        }
    }
}
