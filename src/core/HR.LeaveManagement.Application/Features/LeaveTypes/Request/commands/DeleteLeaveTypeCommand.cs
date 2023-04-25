using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
public class DeleteLeaveTypeCommand : IRequest<Unit>
{
    public DeleteLeaveTypeDto DeleteLeaveTypeDto{ get; set; }
}
