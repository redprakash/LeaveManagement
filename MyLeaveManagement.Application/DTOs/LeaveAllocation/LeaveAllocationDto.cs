using MyLeaveManagement.Application.DTOs.Common;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }

        //[ForeignKey("EmployeeId")]
        //public Employee Employee { get; set; }
        // public string EmployeeId { get; set; }
        // [ForeignKey("LeaveTypeId")]
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
