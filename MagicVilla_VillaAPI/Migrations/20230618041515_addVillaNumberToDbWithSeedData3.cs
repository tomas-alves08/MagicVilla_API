using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumberToDbWithSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 16, 15, 15, 594, DateTimeKind.Local).AddTicks(972));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 15, 51, 39, 528, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "VillaNo", "SpecialDetails", "CreateDate", "UpdateDate"},
                values: new object[] { 101, "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb", new DateTime(2023, 6, 18, 15, 51, 39, 528, DateTimeKind.Local).AddTicks(1277), "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb", "https://www.google.com/search?q=house+image&rlz=1C1CHBF_enNZ1059NZ1059&oq=house+image&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIQCAEQLhiDARjUAhixAxiABDINCAIQABiDARixAxiABDITCAMQLhiDARjHARixAxjRAxiABDIQCAQQABiDARixAxjJAxiABDIKCAUQABiSAxiABDIKCAYQABiSAxiKBTIHCAcQABiABDINCAgQABiDARixAxiABDINCAkQLhiDARixAxiABNIBCDM4MzZqMGo3qAIAsAIA&sourceid=chrome&ie=UTF-8#imgrc=SMS6PVhHgfAqTM", "Tomas Villa", 5, 200.0, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
