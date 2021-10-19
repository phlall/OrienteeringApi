using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class Subject_AgeGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "LessonSubjects",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "LessonSubjects");
        }
    }
}
