
using FluentValidation;
using HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validator;
public class UpdateLeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto> 
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public UpdateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;
        Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));
    }

}
