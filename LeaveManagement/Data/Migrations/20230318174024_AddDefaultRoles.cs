using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "dc4702bc-22ff-4d5d-a312-fb600bd4af1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "ead36765-225d-4b47-85a5-a68e55d74a7e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d40b7a-96d8-4d77-81d4-68ec0ebf757d", "AQAAAAEAACcQAAAAEGjrGUEGcK/DRGqRABVFAAhIjwZnofgoIkFCzC2jmwdbPqr2I0OLF/9RrzqUZeXnOg==", "f96c01a6-fd12-49ce-8aae-27237a59ac0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2924809-202d-4437-9a80-ec483e4dbbca", "AQAAAAEAACcQAAAAEL/gDzFG46iYmnNCVyKLzljUIZjD2RfoaRnu7jPDmPGudzmhs7Z8eB8wS5SpuIDFhA==", "15ada2f9-232e-47b9-8434-e3000b6a2ca4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
