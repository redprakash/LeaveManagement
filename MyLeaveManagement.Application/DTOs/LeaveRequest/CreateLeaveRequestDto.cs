﻿

namespace MyLeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto 
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveRequestComments { get; set; }
    }
}
