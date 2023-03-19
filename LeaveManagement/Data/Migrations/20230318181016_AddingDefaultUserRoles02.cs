using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingDefaultUserRoles02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "495d3ce4-0ee5-49de-a683-bcec419d5cd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "2567a189-7960-4b34-b180-ab8a12f931df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "341dfe30-bc62-4941-bd4b-3c4bfad64941", "USERIMPL@TEST.COM", "AQAAAAEAACcQAAAAEHO9svWs+oGzwngKVDhZN6uqa+hjYn7tk2lcgU1SPggzYavz5BghY6TByXTm+JK/JA==", "6487efe9-d460-4e7c-9c0c-f945f28bac08", "UserImpl@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8dea7368-5823-4269-b95e-f0ff14818e17", "ADMINIMPL@TEST.COM", "AQAAAAEAACcQAAAAEMtJbSe0gaPwG28E5vyrl+POFF8zHPqK+VAPKHp0UL9mbjq6Yrag+mZcoQTpgFmJrw==", "838aa2a7-5219-4bf7-95fc-cfde6ca553d3", "AdminImpl@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "1907cce2-cd58-4cab-89f4-9fcdeafa656d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "bb462cc6-c113-4218-bba3-37297359a728");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3fe81634-0e7f-4d1a-b858-eacf64dbe846", null, "AQAAAAEAACcQAAAAED9aNnpkC7Rwx2WwNwmRGjZnhxRxBL6uLkvMZq1vLL1iLkzS37M3GA2+cOKvsmut/g==", "8af813ec-f974-4a47-9d56-510320afcce4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "45afa94c-d8a6-44fd-95c1-19e2bf3a77a3", null, "AQAAAAEAACcQAAAAEC2Ie2do3+hNVWzW69CckCmu9L1uTVqtz10gnW3XMeIjJ/3LD4TjKX/2Vtr1xVsB2g==", "463bec60-2c20-49f6-b20a-82a4e66e85b6", null });
        }
    }
}
