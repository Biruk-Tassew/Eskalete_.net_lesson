 using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validator;
public class CreateLeaveTypeValidator : AbstractValidator<CreateLeaveTypeDto> 
{
    public CreateLeaveTypeValidator()
    {
        Include(new ILeaveTypeValidator());
    }
}
