using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrienteeringApi.Migrations
{
    public partial class TeacherPupil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "LessonGroupSessions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LessonGroupSessionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonGroupSessionId = table.Column<int>(type: "integer", nullable: false),
                    LessonControlId = table.Column<int>(type: "integer", nullable: false),
                    PupilId = table.Column<int>(type: "integer", nullable: false),
                    PupilAnswer = table.Column<string>(type: "text", nullable: true),
                    AnswerDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonGroupSessionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonGroupSessionAnswers_LessonControls_LessonControlId",
                        column: x => x.LessonControlId,
                        principalTable: "LessonControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonGroupSessionAnswers_LessonGroupSessions_LessonGroupSe~",
                        column: x => x.LessonGroupSessionId,
                        principalTable: "LessonGroupSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonGroupSessionAnswers_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroupSessions_TeacherId",
                table: "LessonGroupSessions",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroupSessionAnswers_LessonControlId",
                table: "LessonGroupSessionAnswers",
                column: "LessonControlId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroupSessionAnswers_LessonGroupSessionId",
                table: "LessonGroupSessionAnswers",
                column: "LessonGroupSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroupSessionAnswers_PupilId",
                table: "LessonGroupSessionAnswers",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SchoolId",
                table: "Teacher",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGroupSessions_Teacher_TeacherId",
                table: "LessonGroupSessions",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGroupSessions_Teacher_TeacherId",
                table: "LessonGroupSessions");

            migrationBuilder.DropTable(
                name: "LessonGroupSessionAnswers");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_LessonGroupSessions_TeacherId",
                table: "LessonGroupSessions");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "LessonGroupSessions");
        }
    }
}
