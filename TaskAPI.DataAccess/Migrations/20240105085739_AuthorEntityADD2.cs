using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityADD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "sachi buddhika" },
                    { 2, "smith Perera" },
                    { 3, "maxwell dek" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "Due" },
                values: new object[] { 1, new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(623), "Test Description 01", new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(624), 0, "Test Title 01" },
                    { 3, 1, new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(627), "Test Description 01", new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(628), 0, "Test Title 01" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 23, 38, 438, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 1, 10, 14, 23, 38, 438, DateTimeKind.Local).AddTicks(7301) });
        }
    }
}
