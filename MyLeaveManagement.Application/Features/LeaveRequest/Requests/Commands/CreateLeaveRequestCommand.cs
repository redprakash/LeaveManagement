using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
