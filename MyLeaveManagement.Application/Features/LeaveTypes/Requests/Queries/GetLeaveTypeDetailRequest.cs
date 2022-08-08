using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
