using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class admigraionMap_Title_desc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Maps",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Maps",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Maps");
        }
    }
}
