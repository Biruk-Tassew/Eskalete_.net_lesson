 using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validator;
public class ILeaveTypeValidator : AbstractValidator<ILeaveTypeDto> 
{
    public ILeaveTypeValidator()
    {
        RuleFor(p => p.Name)
        .NotEmpty().WithMessage("{PropertyName} is required!")   
        .NotNull()
        .MaximumLength(15).WithMessage("{PropertyName}'s length shouldn't exceed 15");

        RuleFor(p => p.DefaultDays)
        .NotEmpty().WithMessage("{PropertyName} is required!")   
        .GreaterThan(0).WithMessage("{PropertyName} should be atleast greater than Zero")
        .LessThan(100).WithMessage("{PropertyName} shouldn't exceed 100");
    }
}
