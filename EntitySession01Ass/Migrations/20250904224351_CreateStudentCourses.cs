using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession01Ass.Migrations
{
    /// <inheritdoc />
    public partial class CreateStudentCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false),
                    course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.stud_ID, x.course_ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");
        }
    }
}
