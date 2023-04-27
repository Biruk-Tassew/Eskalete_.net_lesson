using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
public class DeleteLeaveRequestCommand : IRequest<Unit>
{
    public DeleteLeaveRequestDto DeleteLeaveRequestDto{ get; set; }
    public int Id { get; set; }
}
