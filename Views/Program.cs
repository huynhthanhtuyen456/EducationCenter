﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure.DAL;
using Models.Roles;
using Models.Students;
using Models.Subjects;

namespace Views
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EducationCenterContext context = new EducationCenterContext();
            var roles = new List<Role>
            {
                new Role{Name="Student",Description="Test"},
                new Role{Name="Teacher",Description="Test"},
                new Role{Name="Administrator",Description="Test"},
            };
            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",Email="Tester_1@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=1},
            new Student{FirstName="Meredith",LastName="Alonso",Email="Tester_2@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=1},
            new Student{FirstName="Arturo",LastName="Anand",Email="Tester_3@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=1},
            new Student{FirstName="Gytis",LastName="Barzdukas",Email="Tester_4@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=2},
            new Student{FirstName="Yan",LastName="Li",Email="Tester_5@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=2},
            new Student{FirstName="Peggy",LastName="Justice",Email="Tester_6@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=2},
            new Student{FirstName="Laura",LastName="Norman",Email="Tester_7@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=3},
            new Student{FirstName="Nino",LastName="Olivetto",Email="Tester_8@example.com",DateOfBirth=DateTime.Now,Gender=0,RoleId=3}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Subject>
            {
            new Subject{Id=1050,Name="Chemistry",Credits=3,},
            new Subject{Id=4022,Name="Microeconomics",Credits=3,},
            new Subject{Id=4041,Name="Macroeconomics",Credits=3,},
            new Subject{Id=1045,Name="Calculus",Credits=4,},
            new Subject{Id=3141,Name="Trigonometry",Credits=4,},
            new Subject{Id=2021,Name="Composition",Credits=3,},
            new Subject{Id=2042,Name="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B,EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F,EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Enrollment{StudentID=3,CourseID=1050,EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Enrollment{StudentID=4,CourseID=1050,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Enrollment{StudentID=6,CourseID=1045,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A,EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}