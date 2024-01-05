using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityADD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 23, 38, 438, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 1, 10, 14, 23, 38, 438, DateTimeKind.Local).AddTicks(7301) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 13, 55, 926, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 1, 10, 14, 13, 55, 926, DateTimeKind.Local).AddTicks(8779) });
        }
    }
}
