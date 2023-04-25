using FluentValidation;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validator;
public class ILeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto> 
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public ILeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;
        RuleFor(p => p.startDate)
        .LessThan(p => p.endDate).WithMessage("{PropertyName} should be less be before {ComparisonValue}");

        RuleFor(p => p.endDate)
        .GreaterThan(p => p.startDate).WithMessage("{PropertyName} should be less be after {ComparisonValue}");
        
        RuleFor(p => p.startDate)
        .LessThan(p => p.endDate).WithMessage("{PropertyName} should be less be before {ComparisonValue}");

        RuleFor(p => p.LeaveTypeId)
        .GreaterThan(0)
        .MustAsync( async (id, token)=>{
            var leaveTypeExists = await _leaveTypeRepository.Exists(id);
            return !leaveTypeExists;
        }).WithMessage("{PropertyName} doesn't exist");
        
    }
}
