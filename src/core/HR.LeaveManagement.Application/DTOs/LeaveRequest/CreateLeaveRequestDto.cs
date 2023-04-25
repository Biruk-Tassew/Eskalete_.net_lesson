
namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;
public class CreateLeaveRequestDto
{
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}
    public int LeaveTypeId {get; set;}
    public DateTime DateRequested {get; set;}
    public string? RequestComment {get; set;}
}
