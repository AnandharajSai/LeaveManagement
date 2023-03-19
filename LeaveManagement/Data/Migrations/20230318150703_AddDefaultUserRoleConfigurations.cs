using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRoleConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4428abd1-3af4-400d-9d8a-d06f564c7232", "93952e20-4230-4f6e-8999-e5a8f8fa6efd", "Admin", "ADMIN" },
                    { "4428efg1-3af4-400d-9d8a-d06f934c7232", "933db002-1b1d-40b6-b4bc-5eb491b19cd3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", "4428abd1-3af4-400d-9d8a-d06f564c7232" },
                    { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", "4428efg1-3af4-400d-9d8a-d06f934c7232" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxtID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", 0, "2dfbab44-3b4d-4d7f-a60f-198e17f680e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserImpl@test.com", false, "User", "Impl", false, null, null, null, "AQAAAAEAACcQAAAAEOBS1O5u+EU9L9R57GeZRBudPWbFXUgOtkzqZ1JJv41NTp0YNjqQpSEVITYO2b3qiw==", null, false, "78828868-348f-4093-ba8e-6229b3af077d", null, false, null },
                    { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", 0, "ab6fbc6f-fb43-440e-96ff-7a42e6f0c70f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AdminImpl@test.com", false, "Admin", "Impl", false, null, null, null, "AQAAAAEAACcQAAAAEEEGaTcfeNmmxnGR9LutjyOiczBkYQNld0F92NZUzxemqxiJJ0MhCnpKS6MfyYh1eQ==", null, false, "5657a592-77f8-4852-a001-e5439f1007ee", null, false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", "4428abd1-3af4-400d-9d8a-d06f564c7232" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", "4428efg1-3af4-400d-9d8a-d06f934c7232" });

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
