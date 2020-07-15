using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// The full title of course.
        /// Example: CPW 245 Advanced .Net 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The course catalog official description of course.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of college credits awarded for completion of course.
        /// </summary>
        public byte Credits { get; set; }
        /// <summary>
        /// The instructor the teaches the course.
        /// </summary>
        public Instructor CourseInstructor {get; set;}
        /// <summary>
        /// All students currently enrolled in course.
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
