using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class SeedMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "LessonGroups",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "LessonGroups",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "LessonGroups",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "LessonGroups",
            //    keyColumn: "Id",
            //    keyValue: 4);

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] {"Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "PickhurstJunior.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) },
                    { new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "Primary1.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) },
                    { new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153), null, "Primary2.png", new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "LessonGroups",
                columns: new[] { "Id", "AgeGroup", "Conclusion", "Created", "Equipment", "GameBasedLearning", "Intro", "LessonSubjectId", "Location", "MainSession", "Modified", "Shared", "Warmup" },
                values: new object[,]
                {
                    { 1, "EYFS", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Wheelbarrow", null, null, 1, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { 2, "KS1", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Tweezers", null, null, 2, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { 3, "LKS2", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Football, Socks, Tattoos", null, null, 3, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null },
                    { 4, "UKS2", null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), "Scooter", null, null, 4, null, null, new DateTime(2021, 2, 10, 16, 14, 41, 43, DateTimeKind.Local).AddTicks(5340), true, null }
                });
        }
    }
}
