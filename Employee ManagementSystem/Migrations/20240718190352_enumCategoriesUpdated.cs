using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class enumCategoriesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Supervisor",
                table: "Employees",
                newName: "SupervisorCategory");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Employees",
                newName: "StateCategory");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Employees",
                newName: "DepartmentCategory");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "ResidentialAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupervisorCategory",
                table: "Employees",
                newName: "Supervisor");

            migrationBuilder.RenameColumn(
                name: "StateCategory",
                table: "Employees",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ResidentialAddress",
                table: "Employees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "DepartmentCategory",
                table: "Employees",
                newName: "Department");
        }
    }
}
