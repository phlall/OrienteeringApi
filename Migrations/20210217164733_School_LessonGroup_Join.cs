using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class School_LessonGroup_Join : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Schools",
            //    keyColumn: "Id",
            //    keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroups_SchoolId",
                table: "LessonGroups",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_Schools_SchoolId",
                table: "LessonGroups",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_Schools_SchoolId",
                table: "LessonGroups");

            migrationBuilder.DropIndex(
                name: "IX_LessonGroups_SchoolId",
                table: "LessonGroups");

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Contact", "Created", "Modified", "Name", "Postcode", "Type" },
                values: new object[] { 1, "1 Acatia Crescent", "Miss Hilda Han-Hindenberg", new DateTime(2021, 2, 17, 16, 45, 27, 472, DateTimeKind.Local).AddTicks(1739), new DateTime(2021, 2, 17, 16, 45, 27, 472, DateTimeKind.Local).AddTicks(1739), "St Trinians", "W99 9XX", "Primary" });
        }
    }
}
