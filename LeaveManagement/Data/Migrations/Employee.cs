using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Data.Migrations
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TaxtID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoined { get; set; }

    }
}
