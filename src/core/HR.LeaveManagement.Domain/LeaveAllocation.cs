using System;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;
public class LeaveAllocation : BaseDomainEntity
{
    public LeaveType? LeaveType {get; set;}
    public int LeaveTypeId {get; set;}
    public int NumberOfDays {get; set;}
    public int Period {get; set;}
    
}
