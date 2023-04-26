using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Persistance;
public class LeaveManagementDbContext : DbContext
{
    public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options) : base(options)
    {
    
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagementDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entry.Entity.LastModifiedDate = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
    
    public DbSet<LeaveType> LeaveTypes;
    public DbSet<LeaveRequest> LeaveRequests;
    public DbSet<LeaveAllocation> LeaveAllocations;
}
