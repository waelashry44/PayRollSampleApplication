using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class modifyroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "463af036-a77d-4003-9766-cdd32dd64824");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee441d4-b2be-417d-99a1-347223d1403a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "960fc35d-2c22-4589-991b-9b991579ddcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7583471a-f82d-4f19-a541-20b9205062bb", "0eb76eaa-c1bd-4a8e-a726-fe47809553fd", "PayRollManager", "PAYROLLMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9aafbe96-67bc-493d-ac96-e77671e41b7f", "140e1e47-3ea3-40d3-9cd7-288eed4549c1", "HrManager", "HRMANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7583471a-f82d-4f19-a541-20b9205062bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9aafbe96-67bc-493d-ac96-e77671e41b7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "463af036-a77d-4003-9766-cdd32dd64824", "53b16d95-152d-4568-a46c-a0bbdcce2f92", "PayRollManager", "PAYROLLMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ee441d4-b2be-417d-99a1-347223d1403a", "56b25aa6-fc04-4dcd-b3a2-20bff4290121", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "960fc35d-2c22-4589-991b-9b991579ddcf", "92231803-245a-41e5-af98-986e0bb6eb52", "Viewer", "VIEWER" });
        }
    }
}
