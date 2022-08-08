using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
