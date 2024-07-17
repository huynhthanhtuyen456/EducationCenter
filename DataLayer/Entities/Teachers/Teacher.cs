using DataLayer.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Teachers
{
    public class Teacher : Person
    {
        public Teacher()
        {
            this.TeacherSubjects = new Collection<TeacherSubject>();
        }

        public int SalaryId { get; set; }
        public virtual Salary ?Salary { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
