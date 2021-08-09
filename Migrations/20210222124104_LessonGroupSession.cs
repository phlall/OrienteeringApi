using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrienteeringApi.Migrations
{
    public partial class LessonGroupSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "QAs",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "QAs",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "QAs",
            //    keyColumn: "Id",
            //    keyValue: 3);

            migrationBuilder.CreateTable(
                name: "LessonGroupSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonGroupId = table.Column<int>(type: "integer", nullable: false),
                    Completed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonGroupSessions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonGroupSessions");

            migrationBuilder.InsertData(
                table: "QAs",
                columns: new[] { "Id", "Answer", "LessonSubjectId", "Question" },
                values: new object[,]
                {
                    { 1, "Scotland", 3, "Flag of Scotland" },
                    { 2, "Germany", 3, "Flag of Germany" },
                    { 3, "Ireland", 3, "Flag of Ireland" }
                });
        }
    }
}
