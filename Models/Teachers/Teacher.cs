using Models.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Teachers
{
    public class Teacher : BaseModel
    {
        public Teacher()
        {
            this.TeacherSubjects = new Collection<TeacherSubject>();
        }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int SalaryId { get; set; }
        public virtual Salary Salary { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
