using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRoes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428abd1-3af4-400d-9d8a-d06f564c7232",
                column: "ConcurrencyStamp",
                value: "b0ffe78e-bcfa-4f40-83b7-e59da587e054");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4428efg1-3af4-400d-9d8a-d06f934c7232",
                column: "ConcurrencyStamp",
                value: "0bc3a8b3-8a20-478a-a9ee-d830ac7e0c3c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b60e719c-e2f9-41cd-9ee7-86d3ca0789df", true, "USERIMPL@TEST.COM", "AQAAAAEAACcQAAAAEP3mnlZ48Zz/BwA7d0qNWvd3Nil1hi/TnlaTuTEJQMOrqcGAUDB1z2zXRBNG5e1PaA==", "c20a5fa9-5dca-46ff-bedb-46c19aef0b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47aac8b9-b36f-4513-b924-b1d168ac66d6", true, "ADMINIMPL@TEST.COM", "AQAAAAEAACcQAAAAEJlv/3OXlTLOYnBl69QjJOSRcpb6XVj8Nd3+ZeSarI4/jcJI0UaK+pYiVt4sb9Rrew==", "841f62f0-698f-4803-9180-d3a4cdc27e70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f4e633-87d2-4f4a-9d47-e8a8e057df17", false, null, "AQAAAAEAACcQAAAAEK+58Sj+86kTyauNFPUeVyuvvv5p1Ey7+3Lhx9SbBdntiaO4wHRhJXtMv6LPHE4YJw==", "b1967ce9-3c60-4d45-ad44-1e3b6149e7c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04fb5c74-713b-4bca-8b95-3a13a4ecbca2", false, null, "AQAAAAEAACcQAAAAEG0JyPutC9V0ps7DSFh/OzP1COYsXtBolJkMOblvnwT46f7YReA2crUqqmQ+LVqhsA==", "e9292d97-c79e-4f71-9096-08da571a7a50" });
        }
    }
}
