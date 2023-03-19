using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingMailerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf9af7ee-2b77-43e9-8cb9-ee8850484738", "AQAAAAEAACcQAAAAEID68jn8Zccl/Ncxibaef9J4EBD4NhiRrkcFQ7VzkfaiktAs+xyMqaMHevJ/qdHWNw==", "27fa8d1b-08e9-41e6-97e1-e01dcc9a539f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e117eba3-18f5-4e5d-8db1-3a8b400be80c", "AQAAAAEAACcQAAAAEIkuU+tDCvDp6OPRyXvj970BZ9le4plzFcHPxn8YpACZwRDsFNu0uyU02jfrIR1x3Q==", "4a441946-c39e-4683-a4a5-de67048630d2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "341dfe30-bc62-4941-bd4b-3c4bfad64941", "AQAAAAEAACcQAAAAEHO9svWs+oGzwngKVDhZN6uqa+hjYn7tk2lcgU1SPggzYavz5BghY6TByXTm+JK/JA==", "6487efe9-d460-4e7c-9c0c-f945f28bac08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dea7368-5823-4269-b95e-f0ff14818e17", "AQAAAAEAACcQAAAAEMtJbSe0gaPwG28E5vyrl+POFF8zHPqK+VAPKHp0UL9mbjq6Yrag+mZcoQTpgFmJrw==", "838aa2a7-5219-4bf7-95fc-cfde6ca553d3" });
        }
    }
}
