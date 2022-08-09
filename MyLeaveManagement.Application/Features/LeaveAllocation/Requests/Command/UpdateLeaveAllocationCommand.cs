using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveAllocation;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Command
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
