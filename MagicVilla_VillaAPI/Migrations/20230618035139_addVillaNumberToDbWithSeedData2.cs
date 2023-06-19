using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumberToDbWithSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreateDate", "SpecialDetails", "UpdateDate" },
                values: new object[] { 101, new DateTime(2023, 6, 18, 15, 51, 39, 528, DateTimeKind.Local).AddTicks(1431), "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 15, 51, 39, 528, DateTimeKind.Local).AddTicks(1277));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101);

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
    }
}
