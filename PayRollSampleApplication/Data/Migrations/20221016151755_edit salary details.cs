using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class editsalarydetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "SalaryDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "SalaryDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
