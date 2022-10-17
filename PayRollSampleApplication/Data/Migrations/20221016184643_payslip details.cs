using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class payslipdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaySlipDetail_Employees_EmployeeId",
                table: "PaySlipDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaySlipDetail",
                table: "PaySlipDetail");

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

            migrationBuilder.RenameTable(
                name: "PaySlipDetail",
                newName: "PaySlipDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PaySlipDetail_EmployeeId",
                table: "PaySlipDetails",
                newName: "IX_PaySlipDetails_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaySlipDetails",
                table: "PaySlipDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e1b1318-daa9-413f-a590-0f7bde6cb7e2", "4207523a-c3eb-469e-924e-5f1485353964", "PayRollManager", "PAYROLLMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1176d16a-794a-4b6c-abca-434126f5aa56", "ae1451db-7065-418c-a0d7-54a22f377095", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cc00fb4-c208-4c0c-8ca0-276ac0c59ecc", "ab76bba4-0930-454d-8652-fce99c3ebd9e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_PaySlipDetails_Employees_EmployeeId",
                table: "PaySlipDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaySlipDetails_Employees_EmployeeId",
                table: "PaySlipDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaySlipDetails",
                table: "PaySlipDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e1b1318-daa9-413f-a590-0f7bde6cb7e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1176d16a-794a-4b6c-abca-434126f5aa56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cc00fb4-c208-4c0c-8ca0-276ac0c59ecc");

            migrationBuilder.RenameTable(
                name: "PaySlipDetails",
                newName: "PaySlipDetail");

            migrationBuilder.RenameIndex(
                name: "IX_PaySlipDetails_EmployeeId",
                table: "PaySlipDetail",
                newName: "IX_PaySlipDetail_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaySlipDetail",
                table: "PaySlipDetail",
                column: "Id");

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
                name: "FK_PaySlipDetail_Employees_EmployeeId",
                table: "PaySlipDetail",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
