using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class LessonGroupSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "LessonSubjects",
            //    keyColumn: "Id",
            //    keyValue: 6);

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "AgeGroup", "Conclusion", "Created", "Equipment", "GameBasedLearning", "Intro", "LessonSubjectId", "Location", "MainSession", "Modified", "Shared", "Warmup" },
                values: new object[,]
                {
                    { "EYFS", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Wheelbarrow", null, null, 1, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { "KS1", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Tweezers", null, null, 2, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { "LKS2", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Football, Socks, Tattoos", null, null, 3, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { "UKS2", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Scooter", null, null, 4, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "LessonSubjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Decode a Message" },
                    { 2, "Find The Sport Star" },
                    { 3, "Sporting Anagrams" },
                    { 4, "Fitness Circuit" },
                    { 5, "Flags" },
                    { 6, "Maths" }
                });
        }
    }
}
