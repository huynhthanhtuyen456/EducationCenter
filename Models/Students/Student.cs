using Models.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Students
{
    public class Student : Person
    {
        public Student()
        {
            this.Enrollments = new Collection<Enrollment>();
        }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
