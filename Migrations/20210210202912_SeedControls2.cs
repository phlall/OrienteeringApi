using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class SeedControls2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Controls",
                columns: new[] { "Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "A very well hidden control", "image1", new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "A well placed control", "image2", new DateTime(2021, 2, 10, 20, 39, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "Behind the bike rack", "image3", new DateTime(2021, 2, 10, 20, 49, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "On a wall", "image4", new DateTime(2021, 2, 10, 20, 59, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "Under a hat", "image5", new DateTime(2021, 2, 10, 21, 9, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "In a room", "image6", new DateTime(2021, 2, 10, 21, 19, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "On the rrof", "image7", new DateTime(2021, 2, 10, 21, 29, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "Behind the curtain", "image8", new DateTime(2021, 2, 10, 21, 39, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "Behind you!", "image9", new DateTime(2021, 2, 10, 21, 49, 11, 666, DateTimeKind.Local).AddTicks(8603) },
                    { new DateTime(2021, 2, 10, 20, 29, 11, 666, DateTimeKind.Local).AddTicks(8603), "In pla", "image10", new DateTime(2021, 2, 10, 21, 59, 11, 666, DateTimeKind.Local).AddTicks(8603) }
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

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Controls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "Id", "Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "PickhurstJunior.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) },
                    { 2, new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "Primary1.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) },
                    { 3, new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "Primary2.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) }
                });
        }
    }
}
