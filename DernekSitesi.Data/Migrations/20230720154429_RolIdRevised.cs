using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DernekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class RolIdRevised : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 20, 18, 44, 29, 203, DateTimeKind.Local).AddTicks(1551));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 20, 17, 51, 40, 18, DateTimeKind.Local).AddTicks(526));
        }
    }
}
