using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "5888d552-f247-4217-955f-d2bf8540ed7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "a3d2500e-f2df-4c7a-83f7-cc84f4fe9546");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1f70c2-019e-48d7-98b5-38b807729df1", "AQAAAAEAACcQAAAAELTifUEyvVBAGF3gJJlBc29fJGTGyGFJGjZBFCmERVCku+VNgDY6vXktaBdzDnl6WQ==", "6d91159d-41bb-4f5d-95d5-4c5737a09080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20296e2d-07ee-4ce5-8486-5b5af45592d8", "AQAAAAEAACcQAAAAEGJC39d++4HD7DYgOe8yZNkbw6w4+5wbncAo8r9ZknJwaw2d2Breya4Z27u0Q6tHjA==", "bf5d25de-8ef9-429a-a3f3-0559b94e766d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "20edf565-4e1a-4581-a51d-1c38d1c57b61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "2dbe6c5d-a275-49b1-9f61-c9f601edc9fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398165ce-eba9-4a13-8813-2ddd03f065c9", "AQAAAAEAACcQAAAAEE/aSdB3ofQ/u+Ka2rlxKBIUcUOXN4yaJyx+1/bhbyzMXDAIXVgtikU/1iXDopuJXw==", "89b7b436-e3cb-474c-8747-28a26db85e70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d9e3d84-d2b5-4507-9755-1e4eccc94ffd", "AQAAAAEAACcQAAAAENpFBMrvaBpEtmJkqxD/eooZWh24V0ZY7LTR0/EoIiJbxodn7TllJsFhnYbY1XCL5w==", "a3d4bb24-2019-4914-a74f-4329b2e0f4b2" });
        }
    }
}
