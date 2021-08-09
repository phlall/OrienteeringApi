using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class LessonGroup_Maps_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LessonGroups_MapId",
                table: "LessonGroups",
                column: "MapId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups");

            migrationBuilder.DropIndex(
                name: "IX_LessonGroups_MapId",
                table: "LessonGroups");
        }
    }
}
