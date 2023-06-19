using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb", "https://www.google.com/search?q=house+image&rlz=1C1CHBF_enNZ1059NZ1059&oq=house+image&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIQCAEQLhiDARjUAhixAxiABDINCAIQABiDARixAxiABDITCAMQLhiDARjHARixAxjRAxiABDIQCAQQABiDARixAxjJAxiABDIKCAUQABiSAxiABDIKCAYQABiSAxiKBTIHCAcQABiABDINCAgQABiDARixAxiABDINCAkQLhiDARixAxiABNIBCDM4MzZqMGo3qAIAsAIA&sourceid=chrome&ie=UTF-8#imgrc=SMS6PVhHgfAqTM", "Tomas Villa", 5, 200.0, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
