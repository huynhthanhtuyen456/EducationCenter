using Models.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models.Students
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment : BaseModel
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public bool IsFinished { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}
