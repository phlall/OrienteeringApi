using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class School_LessonGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapNodes_Schools_SchoolId",
                table: "MapNodes");

            migrationBuilder.DropIndex(
                name: "IX_MapNodes_SchoolId",
                table: "MapNodes");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "MapNodes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "MapNodes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapNodes_SchoolId",
                table: "MapNodes",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapNodes_Schools_SchoolId",
                table: "MapNodes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
