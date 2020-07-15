using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInstr = new Instructor()
            {
                FullName = "Bob Dole",
                Email = "BDole@cptc.edu"
            };
            Student s1 = new Student()
            {
                FirstName = "Jimmy",
                LastName = "Boy"
            };
            Student s2 = new Student()
            {
                FirstName = "Paula",
                LastName = "Queen"
            };
            Student s3 = new Student()
            {
                FirstName = "Greg",
                LastName = "Mayo"
            };

            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - Adv .Net";
            testCourse.Description = "More .Net that you didn't learn";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInstr;
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);


            Console.WriteLine(testCourse.Title);
            Console.WriteLine("This course is taught by " + testCourse.CourseInstructor.FullName);

            Console.WriteLine("The currently enrolled students: ");
            foreach (Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            Console.ReadKey();
        }
    }
}
