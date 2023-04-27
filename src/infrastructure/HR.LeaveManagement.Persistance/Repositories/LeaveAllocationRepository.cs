
using HR.LeaveManagement.Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Persistance.Repository;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private readonly LeaveManagementDbContext _dbContext;
    public LeaveAllocationRepository(LeaveManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
    {
        return await _dbContext.LeaveAllocations
        .Include(p => p.LeaveType).ToListAsync();
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
    {
        return await _dbContext.LeaveAllocations
        .Include(p => p.LeaveType)
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}