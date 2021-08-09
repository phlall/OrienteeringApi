using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class SeedControls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Controls",
                columns: new[] { "Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "A very well hidden control", "image1", new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001) },
                    { new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "A well placed control", "image2", new DateTime(2021, 2, 10, 15, 0, 14, 986, DateTimeKind.Local).AddTicks(6001) },
                    { new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "Behind the bike rack", "image3", new DateTime(2021, 2, 10, 15, 10, 14, 986, DateTimeKind.Local).AddTicks(6001) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
