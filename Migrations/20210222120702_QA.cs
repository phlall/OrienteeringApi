using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class QA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_Controls_ControlId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_Maps_MapId",
                table: "LessonControls");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_ControlId",
                table: "LessonControls");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_MapId",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "ControlId",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "LessonControls");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "LessonControls",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ControlId",
                table: "LessonControls",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "LessonControls",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "LessonControls",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_ControlId",
                table: "LessonControls",
                column: "ControlId");

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
                name: "FK_LessonControls_Maps_MapId",
                table: "LessonControls",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
