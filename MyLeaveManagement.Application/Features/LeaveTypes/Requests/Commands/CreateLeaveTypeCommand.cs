using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
