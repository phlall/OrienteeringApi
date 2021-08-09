using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class SeedSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Contact", "Created", "Modified", "Name", "Postcode", "Type" },
                values: new object[] { 1, "1 Acatia Crescent", "Miss Hilda Han-Hindenberg", new DateTime(2021, 2, 17, 16, 44, 0, 390, DateTimeKind.Local).AddTicks(2241), new DateTime(2021, 2, 17, 16, 44, 0, 390, DateTimeKind.Local).AddTicks(2241), "St Trinians", "W99 9XX", "Primary" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
