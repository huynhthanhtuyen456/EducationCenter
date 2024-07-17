using DataLayer.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Administrators
{
    public class Administrator : BaseModel
    {
        public float WorkingHours { get; set; }

        public int SalaryId { get; set; }
        public virtual Salary ?Salary { get; set; }

        public bool IsFullTime { get; set; }
    }
}
