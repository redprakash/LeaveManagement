using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveAllocation;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}
