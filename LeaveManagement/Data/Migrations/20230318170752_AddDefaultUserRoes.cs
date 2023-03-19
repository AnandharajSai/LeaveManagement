using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", "4428abd1-3af4-400d-9d8a-d06f564c7232" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", "4428efg1-3af4-400d-9d8a-d06f934c7232" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "85ef8921-f8c3-4eb9-9985-71c6db7c2b80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "e85fe7b6-c23f-4cc5-b40e-9158be17dd9e");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4428efg1-3af4-400d-9d8a-d06f934c7232", "4f056e5b-8474-40f0-91a6-15c87b0ff0e9" },
                    { "4428abd1-3af4-400d-9d8a-d06f564c7232", "6f035e5b-9818-40f0-35a6-15c86b0ff0e9" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f4e633-87d2-4f4a-9d47-e8a8e057df17", "AQAAAAEAACcQAAAAEK+58Sj+86kTyauNFPUeVyuvvv5p1Ey7+3Lhx9SbBdntiaO4wHRhJXtMv6LPHE4YJw==", "b1967ce9-3c60-4d45-ad44-1e3b6149e7c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04fb5c74-713b-4bca-8b95-3a13a4ecbca2", "AQAAAAEAACcQAAAAEG0JyPutC9V0ps7DSFh/OzP1COYsXtBolJkMOblvnwT46f7YReA2crUqqmQ+LVqhsA==", "e9292d97-c79e-4f71-9096-08da571a7a50" });
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "93952e20-4230-4f6e-8999-e5a8f8fa6efd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "933db002-1b1d-40b6-b4bc-5eb491b19cd3");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f035e5b-9818-40f0-35a6-15c86b0ff0e9", "4428abd1-3af4-400d-9d8a-d06f564c7232" },
                    { "4f056e5b-8474-40f0-91a6-15c87b0ff0e9", "4428efg1-3af4-400d-9d8a-d06f934c7232" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dfbab44-3b4d-4d7f-a60f-198e17f680e7", "AQAAAAEAACcQAAAAEOBS1O5u+EU9L9R57GeZRBudPWbFXUgOtkzqZ1JJv41NTp0YNjqQpSEVITYO2b3qiw==", "78828868-348f-4093-ba8e-6229b3af077d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab6fbc6f-fb43-440e-96ff-7a42e6f0c70f", "AQAAAAEAACcQAAAAEEEGaTcfeNmmxnGR9LutjyOiczBkYQNld0F92NZUzxemqxiJJ0MhCnpKS6MfyYh1eQ==", "5657a592-77f8-4852-a001-e5439f1007ee" });
        }
    }
}
