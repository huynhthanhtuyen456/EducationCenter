using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DataLayer.Entities.Roles;
using DataLayer.Entities.Students;
using DataLayer.Entities.Subjects;
using DataLayer.Entities.Teachers;
using DataLayer.Entities.Administrators;

namespace DataLayer
{
    public class EducationCenterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EducationCenterContext"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Administrator", Description = "Administrators have all permissons to manage education center." },
                new Role { Id = 2, Name = "Teacher", Description = "Teachers view the information of students and their enrollments and grades." },
                new Role { Id = 3, Name = "Student", Description = "Students can enroll subjects for study and manage their own information." }
            );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
