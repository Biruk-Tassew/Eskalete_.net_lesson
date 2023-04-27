using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistance.Repository;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    private readonly LeaveManagementDbContext _dbContext;
    public LeaveRequestRepository(LeaveManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
    {
        return await _dbContext.LeaveRequests
        .Include(q => q.LeaveType).ToListAsync();
    }

    public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
    {
        return await _dbContext.LeaveRequests
        .Include(q => q.LeaveType)
        .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task UpdateApprovalStatus(LeaveRequest leaveRequest, bool? approved)
    {
        leaveRequest.Approved = (bool)approved;
        _dbContext.Entry(leaveRequest).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
}