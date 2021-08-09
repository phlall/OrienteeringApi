using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrienteeringApi.Migrations
{
    public partial class PuplilSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SessionPupils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonGroupSessionId = table.Column<int>(type: "integer", nullable: false),
                    PupilId = table.Column<int>(type: "integer", nullable: false),
                    QAId = table.Column<int>(type: "integer", nullable: false),
                    PupilAnswer = table.Column<string>(type: "text", nullable: true),
                    CompletedIn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionPupils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionPupils_LessonGroupSessions_LessonGroupSessionId",
                        column: x => x.LessonGroupSessionId,
                        principalTable: "LessonGroupSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SessionPupils_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SessionPupils_QAs_QAId",
                        column: x => x.QAId,
                        principalTable: "QAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionPupils_LessonGroupSessionId",
                table: "SessionPupils",
                column: "LessonGroupSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionPupils_PupilId",
                table: "SessionPupils",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionPupils_QAId",
                table: "SessionPupils",
                column: "QAId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionPupils");
        }
    }
}
