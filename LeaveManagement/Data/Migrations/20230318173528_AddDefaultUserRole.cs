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
                value: "94290447-f1f0-42b9-b97c-3c78bf8e0494");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "2492a98f-7072-4acb-97d8-1a0236bdaf4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8974d1d5-6624-4fad-a427-18a3ab99fbd6", "AQAAAAEAACcQAAAAEEnKMcuwQGTPW2QXHRl/wZ4rQW5VE3CBGq7UFoFImOJimDaVRcg28+ZvltUUr8NSIg==", "83e3831b-fa14-49d8-bf9d-5140ed38d6a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3186aed-f0b7-4fda-a267-6487ec1ac88b", "AQAAAAEAACcQAAAAEB48MN6u/oQe+wqj+Mb7VKryf0dfpeMfbMZN+SIdvlbgBMIiG6gOH/ljt/4XugpFWw==", "e725be16-fde1-4962-a623-cc841592da5e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
