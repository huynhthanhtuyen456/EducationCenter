using DataLayer.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Students
{
    public class Student : Person
    {
        public Student()
        {
            this.Enrollments = new Collection<Enrollment>();
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
