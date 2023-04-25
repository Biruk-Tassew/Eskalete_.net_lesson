﻿using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation;
public class UpdateLeaveAllocationDto : BaseDto
{
    public LeaveTypeDto? LeaveType {get; set;}
    public int LeaveTypeId {get; set;}
    public int NumberOfDays {get; set;}
    public int Period {get; set;}
    
}
