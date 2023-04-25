using System.Collections.Generic;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts;
public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
    Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
    Task UpdateApprovalStatus(LeaveRequest leaveRequest, bool? approved);
}
 