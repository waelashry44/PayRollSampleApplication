using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class updateentites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_EmployeeId",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAttachments_Employees_EmployeeId",
                table: "EmployeeAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobPosition_JobPositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryDetails_Employees_EmployeeId",
                table: "SalaryDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPosition",
                table: "JobPosition");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "144ce3eb-a7b1-4ef5-b123-1f808dc213ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817b43d7-e7a4-4c3d-ae2d-2002e34763c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f55f469-e22b-4a75-ab62-43b56cf0fe58");

            migrationBuilder.DropColumn(
                name: "JobStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RelationType",
                table: "Dependents");

            migrationBuilder.RenameTable(
                name: "JobPosition",
                newName: "JobPositions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "JobStatusId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "EmployeeAttachments",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeAttachments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentifierNumber",
                table: "Dependents",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Dependents",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPositions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "JobPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPositions",
                table: "JobPositions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JobStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56f35622-bf73-46ed-bdad-1ecf73f56f95", "4bf80b16-b684-44b7-93d1-8e9df218ab6f", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" },
                    { "c8707851-bc80-4ca1-bdc7-ccb2420a5874", "75e1d37b-65a1-4fb7-8384-5639cee06ff3", "Viewer", "VIEWER" },
                    { "ffdbcc0f-0739-4b63-8ca0-2d52ca7e5816", "64f6958c-762c-4aad-968d-dd2f7d2c527c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Project Manager" },
                    { 2, 2, "HR" },
                    { 3, 3, "Marketing Specialist" },
                    { 4, 4, "Accountant" },
                    { 5, 5, "Sales Man" },
                    { 6, 1, "Dot Net developer" }
                });

            migrationBuilder.InsertData(
                table: "JobStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Started" },
                    { 2, "Not Yet Started" },
                    { 3, "Not Working" }
                });

            migrationBuilder.InsertData(
                table: "RelationTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wife" },
                    { 2, "Daughter" },
                    { 3, "Son" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobStatusId",
                table: "Employees",
                column: "JobStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_RelationTypeId",
                table: "Dependents",
                column: "RelationTypeId");

            migrationBuilder.CreateIndex(
                name: "UQDependent_IdentifierNumber",
                table: "Dependents",
                column: "IdentifierNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPositions_DepartmentId",
                table: "JobPositions",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_RelationTypes_RelationTypeId",
                table: "Dependents",
                column: "RelationTypeId",
                principalTable: "RelationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Employees_JobPositions_JobPositionId",
                table: "Employees",
                column: "JobPositionId",
                principalTable: "JobPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobStatuses_JobStatusId",
                table: "Employees",
                column: "JobStatusId",
                principalTable: "JobStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_JobPosition",
                table: "JobPositions",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_RelationTypes_RelationTypeId",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Dependents",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAttachments",
                table: "EmployeeAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobPositions_JobPositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobStatuses_JobStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_JobPosition",
                table: "JobPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_SalaryDetails",
                table: "SalaryDetails");

            migrationBuilder.DropTable(
                name: "JobStatuses");

            migrationBuilder.DropTable(
                name: "RelationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_RelationTypeId",
                table: "Dependents");

            migrationBuilder.DropIndex(
                name: "UQDependent_IdentifierNumber",
                table: "Dependents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPositions",
                table: "JobPositions");

            migrationBuilder.DropIndex(
                name: "IX_JobPositions_DepartmentId",
                table: "JobPositions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f35622-bf73-46ed-bdad-1ecf73f56f95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8707851-bc80-4ca1-bdc7-ccb2420a5874");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffdbcc0f-0739-4b63-8ca0-2d52ca7e5816");

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "JobPositions");

            migrationBuilder.RenameTable(
                name: "JobPositions",
                newName: "JobPosition");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "JobStatusId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "JobStatus",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "EmployeeAttachments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeAttachments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentifierNumber",
                table: "Dependents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Dependents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "RelationType",
                table: "Dependents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPosition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPosition",
                table: "JobPosition",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "144ce3eb-a7b1-4ef5-b123-1f808dc213ae", "8ab274d2-5660-4f72-93a9-4e270c9cf832", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "817b43d7-e7a4-4c3d-ae2d-2002e34763c5", "8402d97d-0f19-4a74-9a0a-2f74bf6c29bc", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f55f469-e22b-4a75-ab62-43b56cf0fe58", "3b2abe34-d6a3-4bee-80b3-79e2acb159a1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_EmployeeId",
                table: "Dependents",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAttachments_Employees_EmployeeId",
                table: "EmployeeAttachments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobPosition_JobPositionId",
                table: "Employees",
                column: "JobPositionId",
                principalTable: "JobPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryDetails_Employees_EmployeeId",
                table: "SalaryDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
