using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingMailerChanges03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "85271acb-e941-45e6-b026-cac8b299fd57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "3f86776f-f6f7-4e89-bf07-b06370392719");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f577b4-670a-403b-8b49-a440d9354eb7", "AQAAAAEAACcQAAAAEG9js5F7k6+SxMOUmr6RzrqyUiml9BGXH1E9OMBNSLHPPnqhYUc/1c7tGvInrtisXQ==", "1238f64e-8394-4b24-84a4-72b49a711ee8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "44bf616d-a344-41d6-bd8d-45dd8eb98391");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "69ba6382-ef43-4924-93ed-c7065c53e114");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e117eba3-18f5-4e5d-8db1-3a8b400be80c", "AQAAAAEAACcQAAAAEIkuU+tDCvDp6OPRyXvj970BZ9le4plzFcHPxn8YpACZwRDsFNu0uyU02jfrIR1x3Q==", "4a441946-c39e-4683-a4a5-de67048630d2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxtID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", 0, "bf9af7ee-2b77-43e9-8cb9-ee8850484738", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserImpl@test.com", true, "User", "Impl", false, null, "USERIMPL@TEST.COM", "USERIMPL@TEST.COM", "AQAAAAEAACcQAAAAEID68jn8Zccl/Ncxibaef9J4EBD4NhiRrkcFQ7VzkfaiktAs+xyMqaMHevJ/qdHWNw==", null, false, "27fa8d1b-08e9-41e6-97e1-e01dcc9a539f", null, false, "UserImpl@test.com" });
        }
    }
}
