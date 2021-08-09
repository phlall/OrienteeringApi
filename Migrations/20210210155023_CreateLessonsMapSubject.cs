using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrienteeringApi.Migrations
{
    public partial class CreateLessonsMapSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Controls",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Controls",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Controls",
            //    keyColumn: "Id",
            //    keyValue: 3);

            migrationBuilder.CreateTable(
                name: "LessonControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonGroupId = table.Column<int>(type: "integer", nullable: false),
                    ControlId = table.Column<int>(type: "integer", nullable: false),
                    MapId = table.Column<int>(type: "integer", nullable: false),
                    YPos = table.Column<int>(type: "integer", nullable: false),
                    XPos = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: true),
                    Question = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonSubjectId = table.Column<int>(type: "integer", nullable: false),
                    AgeGroup = table.Column<string>(type: "text", nullable: true),
                    Shared = table.Column<bool>(type: "boolean", nullable: false),
                    Equipment = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Location = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Intro = table.Column<string>(type: "text", nullable: true),
                    Warmup = table.Column<string>(type: "text", nullable: true),
                    MainSession = table.Column<string>(type: "text", nullable: true),
                    GameBasedLearning = table.Column<string>(type: "text", nullable: true),
                    Conclusion = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Image = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonControls");

            migrationBuilder.DropTable(
                name: "LessonGroups");

            migrationBuilder.DropTable(
                name: "LessonSubjects");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.InsertData(
                table: "Controls",
                columns: new[] { "Id", "Created", "Description", "Image", "Modified" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "A very well hidden control", "image1", new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001) },
                    { 2, new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "A well placed control", "image2", new DateTime(2021, 2, 10, 15, 0, 14, 986, DateTimeKind.Local).AddTicks(6001) },
                    { 3, new DateTime(2021, 2, 10, 14, 50, 14, 986, DateTimeKind.Local).AddTicks(6001), "Behind the bike rack", "image3", new DateTime(2021, 2, 10, 15, 10, 14, 986, DateTimeKind.Local).AddTicks(6001) }
                });
        }
    }
}
