using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntitySession01Ass.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchemaWithRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "CourseInstructors",
                newName: "Course_Inst");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourRate",
                table: "Instructors",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bouns",
                table: "Instructors",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "Stud_Course",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "stud_ID", "course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "inst_ID", "course_ID" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "HiringDate", "Ins_ID", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Computer Science" },
                    { 2, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Information Technology" },
                    { 3, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Software Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Programming" },
                    { 2, "Database" },
                    { 3, "Web Development" },
                    { 4, "Networking" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "Duration", "Name", "Top_ID" },
                values: new object[,]
                {
                    { 1, "Learn C# fundamentals", 60, "C# Programming", 1 },
                    { 2, "Database management", 45, "SQL Server", 2 },
                    { 3, "Web development", 75, "ASP.NET Core", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "Address", "Bouns", "Dept_ID", "HourRate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo", 2000.00m, 1, 50.00m, "Dr. Ahmed Ali", 15000m },
                    { 2, "Alexandria", 2500.00m, 1, 60.00m, "Prof. Mohamed Hassan", 18000m },
                    { 3, "Giza", 2200.00m, 2, 55.00m, "Dr. Sarah Smith", 16000m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "Age", "Dep_Id", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Cairo", 20, 1, "John", "Doe" },
                    { 2, "Alexandria", 21, 1, "Jane", "Smith" },
                    { 3, "Giza", 22, 2, "Mike", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Course_Inst",
                columns: new[] { "course_ID", "inst_ID", "evaluate" },
                values: new object[,]
                {
                    { 1, 1, "Excellent course" },
                    { 2, 2, "Good material" },
                    { 3, 3, "Challenging but rewarding" }
                });

            migrationBuilder.InsertData(
                table: "Stud_Course",
                columns: new[] { "course_ID", "stud_ID", "Grade" },
                values: new object[,]
                {
                    { 1, 1, 85.50m },
                    { 2, 1, 90.00m },
                    { 1, 2, 78.00m },
                    { 3, 3, 92.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_course_ID",
                table: "Stud_Course",
                column: "course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_course_ID",
                table: "Course_Inst",
                column: "course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Courses_course_ID",
                table: "Course_Inst",
                column: "course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructors_inst_ID",
                table: "Course_Inst",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Courses_course_ID",
                table: "Stud_Course",
                column: "course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_stud_ID",
                table: "Stud_Course",
                column: "stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Courses_course_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructors_inst_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Courses_course_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_course_ID",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_course_ID",
                table: "Course_Inst");

            migrationBuilder.DeleteData(
                table: "Course_Inst",
                keyColumns: new[] { "course_ID", "inst_ID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Course_Inst",
                keyColumns: new[] { "course_ID", "inst_ID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Course_Inst",
                keyColumns: new[] { "course_ID", "inst_ID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stud_Course",
                keyColumns: new[] { "course_ID", "stud_ID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Stud_Course",
                keyColumns: new[] { "course_ID", "stud_ID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Stud_Course",
                keyColumns: new[] { "course_ID", "stud_ID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Stud_Course",
                keyColumns: new[] { "course_ID", "stud_ID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                newName: "CourseInstructors");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourRate",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bouns",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "StudentCourses",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "stud_ID", "course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors",
                columns: new[] { "inst_ID", "course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                unique: true,
                filter: "[Dept_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID");
        }
    }
}
