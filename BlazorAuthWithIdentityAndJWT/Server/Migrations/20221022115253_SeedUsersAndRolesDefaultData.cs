using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAuthWithIdentityAndJWT.Server.Migrations
{
    public partial class SeedUsersAndRolesDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3699f95b-bca5-4be1-85f4-8f7a1fc2959f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b08f9be-5c88-4b58-8a07-5ecc59a5a6c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbb3d593-9f08-4a40-8fc1-92e5a2a99a76");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32ecd8d0-3110-40a1-beae-04d1a43aca34", "9cc064ea-4aac-42ff-a7c0-2d7800720ec3", "Visitor", "VISITOR" },
                    { "e532da13-62c4-4582-9d7a-834b080b2ac1", "00f1568e-a3db-4e69-80d4-e7622b5a1f49", "Administrator", "ADMINISTRATOR" },
                    { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "7a9aef8b-1687-4b6d-938e-56ebe345b2be", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b6c9180a-621c-4d6c-9827-6a8a1174fd81", 0, "c33c1cff-ec86-4fe0-bd6d-2015c2a2d950", "user@identity.com", false, "System", "User", false, null, "USER@IDENTITY.COM", "USER", "AQAAAAEAACcQAAAAEJPqqjsArer6rf8xH3jS6b1+xv2WgYV7wUF9mr5ObU6a0gbaV/6K/O6miOJINegjLg==", null, false, null, null, "39cba15f-ca3b-4621-871e-a57d47f4f95b", false, "user" },
                    { "cb5b3ced-a42a-413c-92f6-d18a242c2a5a", 0, "34a2dc0c-9267-47cb-b266-2c6ea1dec6fb", "admin@identity.com", false, "System", "Admin", false, null, "ADMIN@IDENTITY.COM", "ADMIN", "AQAAAAEAACcQAAAAEOqytcJ80Zd+6WzK554U4jS1t2yKsf/E8W54euvEz8YJfr9imfhC25NWWRpoteDLYg==", null, false, null, null, "786b9258-87ee-41b7-8ea1-2172d86e1488", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "b6c9180a-621c-4d6c-9827-6a8a1174fd81" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e532da13-62c4-4582-9d7a-834b080b2ac1", "cb5b3ced-a42a-413c-92f6-d18a242c2a5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ecd8d0-3110-40a1-beae-04d1a43aca34");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "b6c9180a-621c-4d6c-9827-6a8a1174fd81" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e532da13-62c4-4582-9d7a-834b080b2ac1", "cb5b3ced-a42a-413c-92f6-d18a242c2a5a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e532da13-62c4-4582-9d7a-834b080b2ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c9180a-621c-4d6c-9827-6a8a1174fd81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb5b3ced-a42a-413c-92f6-d18a242c2a5a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3699f95b-bca5-4be1-85f4-8f7a1fc2959f", "156150d9-253e-4eab-a7f7-6d522f1d129a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b08f9be-5c88-4b58-8a07-5ecc59a5a6c0", "b7714858-2f14-4fbd-a27f-96cbd3d8ef6f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbb3d593-9f08-4a40-8fc1-92e5a2a99a76", "cc432780-30eb-4e58-81bc-36b08200379a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
