﻿using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;
namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;
public class LeaveRequestListDto : BaseDto
{
    public DateTime startDate {get; set;}    public LeaveTypeDto? LeaveType {get; set;}
    public DateTime DateRequested {get; set;}
    public bool Approved {get; set;}
}
