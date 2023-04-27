using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Persistance.Repository;
public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    private readonly LeaveManagementDbContext _dbContext;
    public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}