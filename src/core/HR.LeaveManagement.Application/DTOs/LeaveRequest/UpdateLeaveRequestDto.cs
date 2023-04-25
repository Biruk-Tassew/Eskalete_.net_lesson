using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;
public class UpdateLeaveRequestDto : BaseDto, ILeaveRequestDto
{
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}
    public int LeaveTypeId {get; set;}
    public string? RequestComment {get; set;}
    public bool Cancelled {get; set;}
}
