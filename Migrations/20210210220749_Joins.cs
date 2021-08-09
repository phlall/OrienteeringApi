using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class Joins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 6);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 7);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 8);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 9);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 10);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 11);

            //migrationBuilder.DeleteData(
            //    table: "LessonControls",
            //    keyColumn: "Id",
            //    keyValue: 12);

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroups_LessonSubjectId",
                table: "LessonGroups",
                column: "LessonSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_ControlId",
                table: "LessonControls",
                column: "ControlId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_LessonGroupId",
                table: "LessonControls",
                column: "LessonGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_MapId",
                table: "LessonControls",
                column: "MapId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_Controls_ControlId",
                table: "LessonControls",
                column: "ControlId",
                principalTable: "Controls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_LessonGroups_LessonGroupId",
                table: "LessonControls",
                column: "LessonGroupId",
                principalTable: "LessonGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_Maps_MapId",
                table: "LessonControls",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_LessonSubjects_LessonSubjectId",
                table: "LessonGroups",
                column: "LessonSubjectId",
                principalTable: "LessonSubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_Controls_ControlId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_LessonGroups_LessonGroupId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_Maps_MapId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_LessonSubjects_LessonSubjectId",
                table: "LessonGroups");

            migrationBuilder.DropIndex(
                name: "IX_LessonGroups_LessonSubjectId",
                table: "LessonGroups");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_ControlId",
                table: "LessonControls");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_LessonGroupId",
                table: "LessonControls");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_MapId",
                table: "LessonControls");

            migrationBuilder.InsertData(
                table: "LessonControls",
                columns: new[] { "Id", "Answer", "ControlId", "Created", "LessonGroupId", "MapId", "Modified", "Question", "XPos", "YPos" },
                values: new object[,]
                {
                    { 1, "Nicola Adams", 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Female Boxer", 0, 0 },
                    { 2, "Mo Farrah", 2, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Long Distance runner and Olympic Champion", 0, 0 },
                    { 3, "Rory McIlroy", 3, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Golfer from Northern Ireland", 0, 0 },
                    { 4, "Jessica Ennis Hill", 4, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Olympic Heptathlon Champion", 0, 0 },
                    { 5, "Joe Root", 5, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "England Cricket Captain", 0, 0 },
                    { 6, "Andy Murray", 6, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Scottish Tennis Player", 0, 0 },
                    { 7, "Bradley Wiggins", 7, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Cyclist, Tour de France winner and Olympic Champion", 0, 0 },
                    { 8, "Laura Trott", 8, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Female Olympic Cycling Champion", 0, 0 },
                    { 9, "Dame Tanni Grey Thompson", 9, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Ex Paralympic Champion", 0, 0 },
                    { 10, "Chris Hoy", 10, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "British Cycling Champion", 0, 0 },
                    { 11, "Jonny Wilkinson", 11, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "Ex England Rugby Star", 0, 0 },
                    { 12, "Harry Kane", 12, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), 2, 1, new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011), "English Football Player", 0, 0 }
                });
        }
    }
}
