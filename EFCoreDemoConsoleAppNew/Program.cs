using Microsoft.EntityFrameworkCore;

namespace EFCoreDemoConsoleAppNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (var context = new SchoolContext())
            {
                var grade = new Grade()
                {
                   GradeName = "A",
                   Section = "Section B"
                };

                context.Grades.Add(grade);
                context.SaveChanges();

                var student = new Student()
                {
                    StudentName = "John",
                    Grade = grade
                };

                context.Students.Add(student);
                context.SaveChanges();
            }*/

            // LINQ - to - Entities
            /*var context = new SchoolContext();

            var studentsWithNameAsJohn = context.Students
                .Where(s => s.StudentName == GetName())
                .ToList();

            Console.WriteLine(studentsWithNameAsJohn[0].StudentName);*/

            /*var context = new SchoolContext();

            var studentWithGrade = context.Students
                .Where(s => s.StudentName == "John")
                .Include(s => s.Grade)
                .First();

            studentWithGrade = context.Students
                .Where(s => s.StudentName == "John")
                .Include("Grade")
                .First(); // NOT RECOMMENDED

            studentWithGrade = context.Students
                .FromSqlRaw("SELECT * FROM Student WHERE StudentName = 'John'")
                .Include(s => s.Grade)
                .First();


            studentWithGrade = context.Students
                .Where(s => s.StudentName == "John")
                .Include(s => s.Grade)
                .Include(s => s.StudentCourse)
                .First();


            // ThenInclude
            studentWithGrade = context.Students
                .Where(s => s.StudentName == "John")
                .Include(s => s.Grade)
                    .ThenInclude(g => g.Teacher)
                .Include(s => s.StudentCourse)
                .First();


            // Projection Query
            var student = context.Students
                .Where(s => s.StudentName == "John")
                .Select(s => new
                {
                    Student = s,
                    Grade = s.Grade,
                    GradeTeachers = s.Grade.Teacher
                })
                .First();*/

            // Update Data

            using (var context = new SchoolContext())
            {
                var student = context.Students.First<Student>();
                student.StudentName = "Jane";
                context.SaveChanges();

                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public static string GetName()
        {
            return "John";
        }
    }
}