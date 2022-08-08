using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeaveManagement.Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto
    {
        public string Name { get; set; }
        public string DefaultDays { get; set; }
    }
}
