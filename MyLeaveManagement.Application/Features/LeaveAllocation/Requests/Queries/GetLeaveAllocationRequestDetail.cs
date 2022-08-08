using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveAllocation;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationRequestDetail : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
