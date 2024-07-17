using Models.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Teachers
{
    public class TeacherSubject : BaseModel
    {
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int Position { get; set; }
        public DateTime Date { get; set; }
    }
}
