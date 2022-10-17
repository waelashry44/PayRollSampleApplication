using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayRollSampleApplication.Data.Migrations
{
    public partial class payslipdetailsrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaySlipDetails_EmployeeId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipDetails_EmployeeId",
                table: "PaySlipDetails",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaySlipDetails_EmployeeId",
                table: "PaySlipDetails");

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
                values: new object[] { "0e1b1318-daa9-413f-a590-0f7bde6cb7e2", "4207523a-c3eb-469e-924e-5f1485353964", "PayRollManager", "PAYROLLMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1176d16a-794a-4b6c-abca-434126f5aa56", "ae1451db-7065-418c-a0d7-54a22f377095", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cc00fb4-c208-4c0c-8ca0-276ac0c59ecc", "ab76bba4-0930-454d-8652-fce99c3ebd9e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipDetails_EmployeeId",
                table: "PaySlipDetails",
                column: "EmployeeId",
                unique: true);
        }
    }
}
