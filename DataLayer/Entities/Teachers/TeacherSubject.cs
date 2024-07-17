using DataLayer.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Teachers
{
    public class TeacherSubject : BaseModel
    {
        public int TeacherId { get; set; }
        public required virtual Teacher Teacher { get; set; }
        public int SubjectId { get; set; }
        public required virtual Subject Subject { get; set; }
        public int Position { get; set; }
        public DateTime Date { get; set; }
    }
}
