using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DernekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Yonetim_entity_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 19, 18, 44, 16, 308, DateTimeKind.Local).AddTicks(3894));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 7, 13, 19, 47, 20, 46, DateTimeKind.Local).AddTicks(2781));
        }
    }
}
