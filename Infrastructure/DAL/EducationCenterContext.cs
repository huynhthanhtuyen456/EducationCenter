using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Models.Students;
using Models.Subjects;
using Models.Roles;

namespace Infrastructure.DAL
{
    public class EducationCenterContext : DbContext
    {
        public EducationCenterContext() : base("EducationCenterContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
