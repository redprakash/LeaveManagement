using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
