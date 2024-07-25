using DataLayer.Entities.Students;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Subjects
{
    public class Subject : BaseModel
    {
        public Subject()
        {
            this.Enrollments = new Collection<Enrollment>();
        }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required int Credits { get; set; }
        public required float Duration { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
