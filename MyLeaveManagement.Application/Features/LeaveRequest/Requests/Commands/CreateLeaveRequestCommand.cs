using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;
using MyLeaveManagement.Application.Responses;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
