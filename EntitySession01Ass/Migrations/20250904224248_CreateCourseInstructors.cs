using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession01Ass.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseInstructors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInstructors",
                columns: table => new
                {
                    inst_ID = table.Column<int>(type: "int", nullable: false),
                    course_ID = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructors", x => new { x.inst_ID, x.course_ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInstructors");
        }
    }
}
