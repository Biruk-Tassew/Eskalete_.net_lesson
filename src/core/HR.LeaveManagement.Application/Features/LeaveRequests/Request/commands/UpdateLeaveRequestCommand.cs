using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
public class UpdateLeaveRequestCommand : IRequest<Unit>
{
    public int Id {get; set;}
    public UpdateLeaveRequestDto UpdateLeaveRequestDto{ get; set; }
    public UpdateLeaveRequestApprovalDto UpdateLeaveRequestApprovalDto {get; set;}
}
