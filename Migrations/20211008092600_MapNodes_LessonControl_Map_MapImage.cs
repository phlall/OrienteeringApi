using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrienteeringApi.Migrations
{
    public partial class MapNodes_LessonControl_Map_MapImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Schools_SchoolId",
                table: "Maps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maps",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "XPos",
                table: "LessonControls");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Maps");

            migrationBuilder.RenameTable(
                name: "Maps",
                newName: "Map");

            migrationBuilder.RenameColumn(
                name: "YPos",
                table: "LessonControls",
                newName: "MapNodeId");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Map",
                newName: "MapImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Maps_SchoolId",
                table: "Map",
                newName: "IX_Map_MapImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Map",
                table: "Map",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MapImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapImages_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapNode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MapId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    YPos = table.Column<int>(type: "integer", nullable: false),
                    XPos = table.Column<int>(type: "integer", nullable: false),
                    SchoolId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapNode_Map_MapId",
                        column: x => x.MapId,
                        principalTable: "Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapNode_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonControls_MapNodeId",
                table: "LessonControls",
                column: "MapNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_MapImages_SchoolId",
                table: "MapImages",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_MapNode_MapId",
                table: "MapNode",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_MapNode_SchoolId",
                table: "MapNode",
                column: "SchoolId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "MapImages");

            migrationBuilder.DropTable(
                name: "MapNode");

            migrationBuilder.DropIndex(
                name: "IX_LessonControls_MapNodeId",
                table: "LessonControls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Map",
                table: "Map");

            migrationBuilder.RenameTable(
                name: "Map",
                newName: "Maps");

            migrationBuilder.RenameColumn(
                name: "MapNodeId",
                table: "LessonControls",
                newName: "YPos");

            migrationBuilder.RenameColumn(
                name: "MapImageId",
                table: "Maps",
                newName: "SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Map_MapImageId",
                table: "Maps",
                newName: "IX_Maps_SchoolId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LessonControls",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "XPos",
                table: "LessonControls",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Maps",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maps",
                table: "Maps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroups_Maps_MapId",
                table: "LessonGroups",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Schools_SchoolId",
                table: "Maps",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
