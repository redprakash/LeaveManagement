using MyLeaveManagement.Application.DTOs.Common;

namespace MyLeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; } 
        public int DefaultDays { get; set; }
    }
}
