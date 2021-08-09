using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class LessonGroup_LessonGroupSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LessonGroupSessions_LessonGroupId",
                table: "LessonGroupSessions",
                column: "LessonGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroupSessions_LessonGroups_LessonGroupId",
                table: "LessonGroupSessions",
                column: "LessonGroupId",
                principalTable: "LessonGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroupSessions_LessonGroups_LessonGroupId",
                table: "LessonGroupSessions");

            migrationBuilder.DropIndex(
                name: "IX_LessonGroupSessions_LessonGroupId",
                table: "LessonGroupSessions");
        }
    }
}
