using Models.Students;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subjects
{
    public class Subject : BaseModel
    {
        public Subject()
        {
            this.Enrollments = new Collection<Enrollment>();
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
