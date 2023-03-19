using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "800a353b-b466-4592-a838-96f33cd5e02b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "03fc3b5a-1bb7-4a4d-89d9-794d24375e48");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b14073a3-88ad-4710-84c5-6ba07d781f54", "AQAAAAEAACcQAAAAEHG/MnW8jJmFWLnrT3iPNZkydOZ9LC7sJyNgiyEAPO31YYCzh0dMLQ9Cne/bcDlgXQ==", "a01934f5-066d-45bc-9549-c928eae4b3d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfa17c8f-1c78-4cc5-9e4d-8039602273f2", "AQAAAAEAACcQAAAAENAgw4OnYeN1FyKsjzNKu0u1yk9pDO07p6ll5UB/Jv4phgUZIAuMrBFTR0DolhX1gA==", "8ec0732d-fb6d-4ed6-93a2-4195a0314fc2" });
        }
    }
}
