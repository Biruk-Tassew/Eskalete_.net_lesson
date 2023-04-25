
using FluentValidation;
using HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validator;
public class UpdateLeaveAllocationDtoValidator : AbstractValidator<ILeaveRequestDto> 
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public UpdateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;
        Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));
    }

}
