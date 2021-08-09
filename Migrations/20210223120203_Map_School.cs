using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class Map_School : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Maps_SchoolId",
                table: "Maps",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Schools_SchoolId",
                table: "Maps",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Schools_SchoolId",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Maps_SchoolId",
                table: "Maps");
        }
    }
}
