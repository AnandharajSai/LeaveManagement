using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDefaultUserRoes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b60e719c-e2f9-41cd-9ee7-86d3ca0789df", "AQAAAAEAACcQAAAAEP3mnlZ48Zz/BwA7d0qNWvd3Nil1hi/TnlaTuTEJQMOrqcGAUDB1z2zXRBNG5e1PaA==", "c20a5fa9-5dca-46ff-bedb-46c19aef0b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47aac8b9-b36f-4513-b924-b1d168ac66d6", "AQAAAAEAACcQAAAAEJlv/3OXlTLOYnBl69QjJOSRcpb6XVj8Nd3+ZeSarI4/jcJI0UaK+pYiVt4sb9Rrew==", "841f62f0-698f-4803-9180-d3a4cdc27e70" });
        }
    }
}
