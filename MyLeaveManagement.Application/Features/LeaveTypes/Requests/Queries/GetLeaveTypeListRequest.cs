using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
