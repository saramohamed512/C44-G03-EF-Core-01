using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession01.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmpDeptView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"Create View EmployeeDepartmentView
                With Encryption , SchemaBinding
                AS
                Select E.Id EmpID, E.EmployeeName , D.DeptId DepartmentId , D.DeptName
                From dbo.Employees E jion dbo.Departments 
                on D.DeptId=E.DepartmentId"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View EmployeeDepartmentView");

        }
    }
}
