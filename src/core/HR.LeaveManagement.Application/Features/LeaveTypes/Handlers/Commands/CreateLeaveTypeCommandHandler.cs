using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveType.Validator;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Application.Responses;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;
public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;
    public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }
    public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateLeaveTypeValidator();
        var validationResult = await  validator.ValidateAsync(request.CreateLeaveTypeDto);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "failed to create Leave type";
            response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
        }

        var leaveType = _mapper.Map<LeaveType>(request.CreateLeaveTypeDto);
        leaveType = await _leaveTypeRepository.Add(leaveType);
        response.Success = true;
        response.Message = "LeaveType created succesfully";
        response.Id = leaveType.Id;
        return response;
    }
}
