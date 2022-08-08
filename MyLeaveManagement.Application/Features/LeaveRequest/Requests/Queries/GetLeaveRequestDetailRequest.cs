using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
