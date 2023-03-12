using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Data.Migrations;
using LeaveManagement.Repository;

namespace LeaveManagement.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
