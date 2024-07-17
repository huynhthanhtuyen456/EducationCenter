using Models.Administrators;
using Models.Students;
using Models.Teachers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Roles
{
    public class Role : BaseModel
    {
        public Role()
        {
            this.Administrators = new Collection<Administrator>();
            this.Students = new Collection<Student>();
            this.Teachers = new Collection<Teacher>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
