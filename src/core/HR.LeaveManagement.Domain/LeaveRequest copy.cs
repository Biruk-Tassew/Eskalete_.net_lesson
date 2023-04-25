using System;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;
public class LeaveRequest : BaseDomainEntity
{
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}
    public LeaveType? LeaveType {get; set;}
    public int LeaveTypeId {get; set;}
    public DateTime DateRequested {get; set;}
    public string? RequestComment {get; set;}
    public DateTime DateActioned {get; set;}
    public bool Approved {get; set;}
    public bool Cancelled {get; set;}
    
}
