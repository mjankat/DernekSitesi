using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DernekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class HasDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 20, 17, 51, 40, 18, DateTimeKind.Local).AddTicks(526));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 20, 17, 46, 48, 97, DateTimeKind.Local).AddTicks(1373));
        }
    }
}
