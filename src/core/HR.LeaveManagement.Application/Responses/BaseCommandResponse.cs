
namespace HR.LeaveManagement.Application.Responses;

public class BaseCommandResponse 
{
    public int Id {get; set;}
    public bool Success{get; set;}
    public string? Message {set; get;}
    public List<string>? Errors {get; set;}

}