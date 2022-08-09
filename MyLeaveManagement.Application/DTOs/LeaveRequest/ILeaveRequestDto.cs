using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLeaveManagement.Application.DTOs.LeaveType;

namespace MyLeaveManagement.Application.DTOs.LeaveRequest
{
    public interface ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
       
        public int LeaveTypeId { get; set; }
       
    }
}
