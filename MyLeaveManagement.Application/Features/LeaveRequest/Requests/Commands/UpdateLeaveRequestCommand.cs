using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public LeaveRequestDto? LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto? ChangeLeaveRequestApprovalDto { get; set; }

    }
}
