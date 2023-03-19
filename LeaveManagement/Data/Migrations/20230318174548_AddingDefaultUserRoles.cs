using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingDefaultUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4428abd1-3af4-400d-9d8a-d06f564c7232", "dc4702bc-22ff-4d5d-a312-fb600bd4af1e", "Admin", "ADMIN" },
                    { "4428efg1-3af4-400d-9d8a-d06f934c7232", "ead36765-225d-4b47-85a5-a68e55d74a7e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxtID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", 0, "91d40b7a-96d8-4d77-81d4-68ec0ebf757d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserImpl@test.com", true, "User", "Impl", false, null, "USERIMPL@TEST.COM", null, "AQAAAAEAACcQAAAAEGjrGUEGcK/DRGqRABVFAAhIjwZnofgoIkFCzC2jmwdbPqr2I0OLF/9RrzqUZeXnOg==", null, false, "f96c01a6-fd12-49ce-8aae-27237a59ac0d", null, false, null },
                    { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", 0, "f2924809-202d-4437-9a80-ec483e4dbbca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AdminImpl@test.com", true, "Admin", "Impl", false, null, "ADMINIMPL@TEST.COM", null, "AQAAAAEAACcQAAAAEL/gDzFG46iYmnNCVyKLzljUIZjD2RfoaRnu7jPDmPGudzmhs7Z8eB8wS5SpuIDFhA==", null, false, "15ada2f9-232e-47b9-8434-e3000b6a2ca4", null, false, null }
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
    }
}
