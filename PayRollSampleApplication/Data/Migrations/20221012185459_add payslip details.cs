using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class addpayslipdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeAttachments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PaySlipDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaySlipDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaySlipDetail_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d432176-6101-40c1-b37c-2ae854e4f377", "aac77c21-8ff0-405a-8665-620743c3a596", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3416e038-c3c4-4676-be1d-c8de6c0f93c5", "d9aab449-c4af-41b1-b260-124f31797a47", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ea46cf9-23b0-4d1b-af65-e6bfe7fb44a3", "d4b85182-43fa-466c-92ad-b037be612c91", "Viewer", "VIEWER" });

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipDetail_EmployeeId",
                table: "PaySlipDetail",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaySlipDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d432176-6101-40c1-b37c-2ae854e4f377");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3416e038-c3c4-4676-be1d-c8de6c0f93c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ea46cf9-23b0-4d1b-af65-e6bfe7fb44a3");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeAttachments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56f35622-bf73-46ed-bdad-1ecf73f56f95", "4bf80b16-b684-44b7-93d1-8e9df218ab6f", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8707851-bc80-4ca1-bdc7-ccb2420a5874", "75e1d37b-65a1-4fb7-8384-5639cee06ff3", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffdbcc0f-0739-4b63-8ca0-2d52ca7e5816", "64f6958c-762c-4aad-968d-dd2f7d2c527c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
