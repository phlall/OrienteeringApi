using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class SeedLessonControls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
              migrationBuilder.InsertData(
                table: "LessonControls",
                columns: new[] { "Answer", "ControlId", "Created", "LessonGroupId", "MapId", "Modified", "Question", "XPos", "YPos" },
                values: new object[,]
                {
                    { "Nicola Adams", 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Female Boxer", 0, 0 },
                    { "Mo Farrah", 2, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Long Distance runner and Olympic Champion", 0, 0 },
                    { "Rory McIlroy", 3, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Golfer from Northern Ireland", 0, 0 },
                    { "Jessica Ennis Hill", 4, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Olympic Heptathlon Champion", 0, 0 },
                    { "Joe Root", 5, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "England Cricket Captain", 0, 0 },
                    { "Andy Murray", 6, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Scottish Tennis Player", 0, 0 },
                    { "Bradley Wiggins", 7, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Cyclist, Tour de France winner and Olympic Champion", 0, 0 },
                    { "Laura Trott", 8, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Female Olympic Cycling Champion", 0, 0 },
                    { "Dame Tanni Grey Thompson", 9, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Ex Paralympic Champion", 0, 0 },
                    { "Chris Hoy", 10, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Cycling Champion", 0, 0 },
                    { "Jonny Wilkinson", 11, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Ex England Rugby Star", 0, 0 },
                    { "Harry Kane", 12, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "English Football Player", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonControls",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "Id", "Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574), null, "PickhurstJunior.png", new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574) },
                    { 2, new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574), null, "Primary1.png", new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574) },
                    { 3, new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574), null, "Primary2.png", new DateTime(2021, 2, 10, 20, 44, 23, 409, DateTimeKind.Local).AddTicks(2574) }
                });
        }
    }
}
