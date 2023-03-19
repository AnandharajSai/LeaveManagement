using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingDefaultUserRoles01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4428abd1-3af4-400d-9d8a-d06f564c7232", "1907cce2-cd58-4cab-89f4-9fcdeafa656d", "Admin", "ADMIN" },
                    { "4428efg1-3af4-400d-9d8a-d06f934c7232", "bb462cc6-c113-4218-bba3-37297359a728", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxtID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", 0, "3fe81634-0e7f-4d1a-b858-eacf64dbe846", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserImpl@test.com", true, "User", "Impl", false, null, "USERIMPL@TEST.COM", null, "AQAAAAEAACcQAAAAED9aNnpkC7Rwx2WwNwmRGjZnhxRxBL6uLkvMZq1vLL1iLkzS37M3GA2+cOKvsmut/g==", null, false, "8af813ec-f974-4a47-9d56-510320afcce4", null, false, null },
                    { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", 0, "45afa94c-d8a6-44fd-95c1-19e2bf3a77a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AdminImpl@test.com", true, "Admin", "Impl", false, null, "ADMINIMPL@TEST.COM", null, "AQAAAAEAACcQAAAAEC2Ie2do3+hNVWzW69CckCmu9L1uTVqtz10gnW3XMeIjJ/3LD4TjKX/2Vtr1xVsB2g==", null, false, "463bec60-2c20-49f6-b20a-82a4e66e85b6", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4428efg1-3af4-400d-9d8a-d06f934c7232", "4f056e5b-8474-40f0-91a6-15c87b0ff0e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4428abd1-3af4-400d-9d8a-d06f564c7232", "6f035e5b-9818-40f0-35a6-15c86b0ff0e9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4428efg1-3af4-400d-9d8a-d06f934c7232", "4f056e5b-8474-40f0-91a6-15c87b0ff0e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4428abd1-3af4-400d-9d8a-d06f564c7232", "6f035e5b-9818-40f0-35a6-15c86b0ff0e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9");
        }
    }
}
