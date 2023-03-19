using LeaveManagement.Data.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var haser = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id= "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                    Email = "AdminImpl@test.com",
                    FirstName ="Admin",
                    LastName="Impl",
                    NormalizedEmail = "ADMINIMPL@TEST.COM",
                    UserName = "AdminImpl@test.com",
                    NormalizedUserName = "ADMINIMPL@TEST.COM",
                    PasswordHash =haser.HashPassword(null,"Admin@123"),
                    EmailConfirmed=true 
                }
                //,
                //new Employee
                //{
                //    Id = "4f056e5b-8474-40f0-91a6-15c87b0ff0e9",
                //    Email = "UserImpl@test.com",
                //    FirstName = "User",
                //    LastName = "Impl",
                //    NormalizedEmail = "USERIMPL@TEST.COM",
                //    UserName = "UserImpl@test.com",
                //    NormalizedUserName = "USERIMPL@TEST.COM",
                //    PasswordHash = haser.HashPassword(null, "Admin@123"),
                //    EmailConfirmed = true
                //}
            );
        }
    }
}