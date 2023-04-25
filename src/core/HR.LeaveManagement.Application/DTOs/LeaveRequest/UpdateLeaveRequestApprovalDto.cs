using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;
public class UpdateLeaveRequestApprovalDto : BaseDto
{
    public bool Approved {get; set;}
}
