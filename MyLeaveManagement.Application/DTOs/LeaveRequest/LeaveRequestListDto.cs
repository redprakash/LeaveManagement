using MyLeaveManagement.Application.DTOs.Common;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.DTOs.LeaveRequest
{
    // Specific Dto to just list the list of leave request 
    // It helps to hide the unwanted info when listing leave requests only
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
