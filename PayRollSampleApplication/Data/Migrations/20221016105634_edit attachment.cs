using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class editattachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "EmployeeAttachments");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43026bd0-e627-4f82-87f2-e29d852fa5d9", "b485029c-32f0-4449-87ba-24854bb7d541", "AdministratorOrViewer", "ADMINISTRATORORVIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9a0bb3c-a6b0-41bb-8656-85170238fd34", "9c8af6ee-7833-4531-8d2a-fd74d63de6f3", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0b57e71-ec2b-4ac3-8636-55284d1bf0fb", "4a280fd6-473d-44b7-81f5-a03b8e71f3b2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43026bd0-e627-4f82-87f2-e29d852fa5d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9a0bb3c-a6b0-41bb-8656-85170238fd34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0b57e71-ec2b-4ac3-8636-55284d1bf0fb");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "EmployeeAttachments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "EmployeeAttachments",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

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
        }
    }
}
