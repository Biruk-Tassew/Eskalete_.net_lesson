using System;
using HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Application.DTOs.LeaveType;
public class LeaveTypeDto : BaseDto
{
    public string? Name {get; set;}
    public string? DefaultDays {get; set;}
    
}
