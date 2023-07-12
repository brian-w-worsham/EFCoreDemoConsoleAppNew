using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static EFCoreDemoConsoleAppNew.Teacher;

namespace EFCoreDemoConsoleAppNew
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
/*
        public Grade Grade { get; set; }

        public StudentCourse StudentCourse { get; set; }*/
    }

   /* public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public Teacher Teacher { get; set; }
    }

    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
    }
    public class StudentCourse
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }*/

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
