using Models.Administrators;
using Models.Teachers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum SalaryLevel
    {
        Fresher = 1,
        Junior = 2,
        Senior = 3,
    }
    public class Salary : BaseModel
    {
        public Salary()
        {
            this.Teachers = new Collection<Teacher>();
            this.Administrators = new Collection<Administrator>();
        }

        [Description("Salary Level")]
        public SalaryLevel Level { get; set; }
        public decimal Wage { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Administrator> Administrators { get; set; }
    }
}
