using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class deletecascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Dependents",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAttachments",
                table: "EmployeeAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83e0db3c-7f46-4189-8cbb-198abd96344f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac6b87d-ec49-4837-95fc-53035b076aee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c49028d9-e99a-4048-97e8-7b3f508dd984");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "116613c1-b84a-4c5f-9da0-463fa86a706e", "43f0b63f-e96a-4dd4-93a2-b69f525915a4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e69a2c7-8fbb-4dab-b79c-bea0faa11398", "a556076e-4ce5-4368-b8a5-c151fc0a7a12", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6424c15c-5da6-44d7-b8a4-020fabce6678", "f429f4c8-0703-43cd-8ded-a2d098e496fb", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Dependents",
                table: "Dependents",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAttachments",
                table: "EmployeeAttachments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Dependents",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAttachments",
                table: "EmployeeAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "116613c1-b84a-4c5f-9da0-463fa86a706e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e69a2c7-8fbb-4dab-b79c-bea0faa11398");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6424c15c-5da6-44d7-b8a4-020fabce6678");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83e0db3c-7f46-4189-8cbb-198abd96344f", "2bda2aad-e065-446c-aa5d-48b4da3865f8", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ac6b87d-ec49-4837-95fc-53035b076aee", "98f43c93-163c-4da6-a0c1-9ed4dc631bdc", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49028d9-e99a-4048-97e8-7b3f508dd984", "a17b9c57-4510-4ea1-b825-7c888411c4ef", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Dependents",
                table: "Dependents",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAttachments",
                table: "EmployeeAttachments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
