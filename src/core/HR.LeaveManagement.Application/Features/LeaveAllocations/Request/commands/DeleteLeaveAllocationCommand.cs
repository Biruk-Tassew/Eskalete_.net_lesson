using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
public class DeleteLeaveAllocationCommand : IRequest<Unit>
{

    public DeleteLeaveAllocationDto DeleteLeaveAllocationDto{ get; set; }
    public int Id { get; set; }
}
