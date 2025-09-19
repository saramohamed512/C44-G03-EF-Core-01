using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession01.Migrations
{
    /// <inheritdoc />
    public partial class CreateGetStudentsByDepartmentSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE InsertStudent
                    @Name NVARCHAR(100),
                    @FName NVARCHAR(50),
                    @LName NVARCHAR(50),
                    @Age INT,
                    @Address NVARCHAR(200),
                    @Dep_Id INT,
                    @NewStudentId INT OUTPUT
                AS
                BEGIN
                    INSERT INTO Students (Name, FName, LName, Age, Address, Dep_Id)
                    VALUES (@Name, @FName, @LName, @Age, @Address, @Dep_Id)
                    
                    SET @NewStudentId = SCOPE_IDENTITY()
                END"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE InsertStudent");
        }
    }
}
