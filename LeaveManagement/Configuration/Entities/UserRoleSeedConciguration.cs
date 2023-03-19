using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    internal class UserRoleSeedConciguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4428abd1-3af4-400d-9d8a-d06f564c7232",
                    UserId = "6f035e5b-9818-40f0-35a6-15c86b0ff0e9",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "4428efg1-3af4-400d-9d8a-d06f934c7232",
                    UserId = "4f056e5b-8474-40f0-91a6-15c87b0ff0e9"
                }
            );
        }
    }
}