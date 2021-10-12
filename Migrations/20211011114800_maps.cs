using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class maps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_MapNode_MapNodeId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_Map_MapId",
                table: "LessonGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Map_MapImages_MapImageId",
                table: "Map");

            migrationBuilder.DropForeignKey(
                name: "FK_MapNode_Map_MapId",
                table: "MapNode");

            migrationBuilder.DropForeignKey(
                name: "FK_MapNode_Schools_SchoolId",
                table: "MapNode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapNode",
                table: "MapNode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Map",
                table: "Map");

            migrationBuilder.RenameTable(
                name: "MapNode",
                newName: "MapNodes");

            migrationBuilder.RenameTable(
                name: "Map",
                newName: "Maps");

            migrationBuilder.RenameIndex(
                name: "IX_MapNode_SchoolId",
                table: "MapNodes",
                newName: "IX_MapNodes_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_MapNode_MapId",
                table: "MapNodes",
                newName: "IX_MapNodes_MapId");

            migrationBuilder.RenameIndex(
                name: "IX_Map_MapImageId",
                table: "Maps",
                newName: "IX_Maps_MapImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapNodes",
                table: "MapNodes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maps",
                table: "Maps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_MapNodes_MapNodeId",
                table: "LessonControls",
                column: "MapNodeId",
                principalTable: "MapNodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapNodes_Maps_MapId",
                table: "MapNodes",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapNodes_Schools_SchoolId",
                table: "MapNodes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_MapImages_MapImageId",
                table: "Maps",
                column: "MapImageId",
                principalTable: "MapImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonControls_MapNodes_MapNodeId",
                table: "LessonControls");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_MapNodes_Maps_MapId",
                table: "MapNodes");

            migrationBuilder.DropForeignKey(
                name: "FK_MapNodes_Schools_SchoolId",
                table: "MapNodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_MapImages_MapImageId",
                table: "Maps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maps",
                table: "Maps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapNodes",
                table: "MapNodes");

            migrationBuilder.RenameTable(
                name: "Maps",
                newName: "Map");

            migrationBuilder.RenameTable(
                name: "MapNodes",
                newName: "MapNode");

            migrationBuilder.RenameIndex(
                name: "IX_Maps_MapImageId",
                table: "Map",
                newName: "IX_Map_MapImageId");

            migrationBuilder.RenameIndex(
                name: "IX_MapNodes_SchoolId",
                table: "MapNode",
                newName: "IX_MapNode_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_MapNodes_MapId",
                table: "MapNode",
                newName: "IX_MapNode_MapId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Map",
                table: "Map",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapNode",
                table: "MapNode",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonControls_MapNode_MapNodeId",
                table: "LessonControls",
                column: "MapNodeId",
                principalTable: "MapNode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_Map_MapId",
                table: "LessonGroups",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Map_MapImages_MapImageId",
                table: "Map",
                column: "MapImageId",
                principalTable: "MapImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapNode_Map_MapId",
                table: "MapNode",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapNode_Schools_SchoolId",
                table: "MapNode",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
