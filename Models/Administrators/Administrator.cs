using Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Administrators
{
    public class Administrator : BaseModel
    {
        public float WorkingHours { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int SalaryId { get; set; }
        public virtual Salary Salary { get; set; }

        public bool IsFullTime { get; set; }
    }
}
