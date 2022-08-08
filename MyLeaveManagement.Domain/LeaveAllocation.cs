using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLeaveManagement.Domain.Common;

namespace MyLeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
       
        public int NumberOfDays { get; set; }
       
        //[ForeignKey("EmployeeId")]
        //public Employee Employee { get; set; }
       // public string EmployeeId { get; set; }
       // [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
