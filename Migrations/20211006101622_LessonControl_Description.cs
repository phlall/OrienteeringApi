using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class LessonControl_Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LessonControls",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_SchoolId",
                table: "Pupils",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pupils_Schools_SchoolId",
                table: "Pupils",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pupils_Schools_SchoolId",
                table: "Pupils");

            migrationBuilder.DropIndex(
                name: "IX_Pupils_SchoolId",
                table: "Pupils");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "LessonControls");
        }
    }
}
