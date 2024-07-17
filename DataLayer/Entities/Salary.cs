using DataLayer.Entities.Administrators;
using DataLayer.Entities.Teachers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
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

        [Column(TypeName = "decimal(5, 2)")]
        [Precision(2)]
        public decimal Wage { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Administrator> Administrators { get; set; }
    }
}
