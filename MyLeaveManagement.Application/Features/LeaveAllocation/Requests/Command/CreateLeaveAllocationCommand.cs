using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveAllocation;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Command
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
