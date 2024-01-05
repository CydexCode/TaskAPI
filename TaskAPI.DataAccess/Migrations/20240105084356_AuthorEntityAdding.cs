using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 13, 55, 926, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 1, 10, 14, 13, 55, 926, DateTimeKind.Local).AddTicks(8779) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 19, 38, 41, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 1, 10, 13, 19, 38, 41, DateTimeKind.Local).AddTicks(1148) });
        }
    }
}
