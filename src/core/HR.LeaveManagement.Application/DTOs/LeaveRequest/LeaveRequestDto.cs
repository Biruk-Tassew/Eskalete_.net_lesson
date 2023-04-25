using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;
public class LeaveRequestDto : BaseDto, ILeaveRequestDto
{
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}
    public LeaveTypeDto? LeaveType {get; set;}
    public int LeaveTypeId {get; set;}
    public DateTime DateRequested {get; set;}
    public string? RequestComment {get; set;}
    public DateTime? DateActioned {get; set;}
    public bool Approved {get; set;}
    public bool Cancelled {get; set;}
}
