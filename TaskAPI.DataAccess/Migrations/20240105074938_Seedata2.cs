using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seedata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedDate", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2024, 1, 5, 13, 19, 38, 41, DateTimeKind.Local).AddTicks(1128), "Test Description 01", new DateTime(2024, 1, 10, 13, 19, 38, 41, DateTimeKind.Local).AddTicks(1148), 0, "Test Title 01" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
