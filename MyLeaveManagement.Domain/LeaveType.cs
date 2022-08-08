using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLeaveManagement.Domain.Common;

namespace MyLeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {

        public string Name { get; set; }
        public int DefaultDays { get; set; }

    }
}
