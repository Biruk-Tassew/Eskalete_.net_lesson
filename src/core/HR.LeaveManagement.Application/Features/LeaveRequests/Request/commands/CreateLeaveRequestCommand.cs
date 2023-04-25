using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
public class CreateLeaveRequestCommand : IRequest<int>
{
    public LeaveAllocationDto LeaveRequestDto{ get; set; }
}
