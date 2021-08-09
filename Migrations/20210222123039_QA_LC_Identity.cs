using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class QA_LC_Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_QAId",
                table: "LessonControls",
                column: "QAId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_QAs_QAId",
                table: "LessonControls",
                column: "QAId",
                principalTable: "QAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_QAs_QAId",
                table: "LessonControls");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_QAId",
                table: "LessonControls");
        }
    }
}
