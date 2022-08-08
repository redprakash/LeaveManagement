using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLeaveManagement.Application.DTOs.Common;

namespace MyLeaveManagement.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}
