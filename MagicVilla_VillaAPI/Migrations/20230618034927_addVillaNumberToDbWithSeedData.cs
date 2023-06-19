using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumberToDbWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreateDate", "SpecialDetails", "UpdateDate" },
                values: new object[] { 1, new DateTime(2023, 6, 18, 15, 49, 27, 759, DateTimeKind.Local).AddTicks(6487), "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 15, 49, 27, 759, DateTimeKind.Local).AddTicks(6336));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 15, 15, 16, 597, DateTimeKind.Local).AddTicks(6793));
        }
    }
}
