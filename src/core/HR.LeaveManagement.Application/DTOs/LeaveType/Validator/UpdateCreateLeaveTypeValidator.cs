 using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validator;
public class UpdateLeaveTypeValidator : AbstractValidator<LeaveTypeDto> 
{
    public UpdateLeaveTypeValidator()
    {
        Include(new ILeaveTypeValidator());

        RuleFor(p => p.Id)
        .NotNull().WithMessage("{PropertyName} must be present");
    }
}
