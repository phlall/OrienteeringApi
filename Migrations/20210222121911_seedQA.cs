using Microsoft.EntityFrameworkCore.Migrations;

namespace OrienteeringApi.Migrations
{
    public partial class seedQA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QAs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QAs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QAs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
