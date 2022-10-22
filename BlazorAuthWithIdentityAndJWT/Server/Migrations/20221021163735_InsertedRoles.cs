using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAuthWithIdentityAndJWT.Server.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00c0797c-bf85-47aa-bb2a-c62743fc9e4e", "5b1994d7-72ee-4015-9064-62b692875723", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3727f258-5a7a-4ef9-85bc-00f7d8ee090a", "80228461-58e0-4ecd-a39c-9a583ccb0089", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8811e650-5d8a-4715-be53-69f17fdb808b", "ba60e9f3-22ae-4d2d-8b0d-3c23e3248731", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c0797c-bf85-47aa-bb2a-c62743fc9e4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3727f258-5a7a-4ef9-85bc-00f7d8ee090a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8811e650-5d8a-4715-be53-69f17fdb808b");
        }
    }
}
