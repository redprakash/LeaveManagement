using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
