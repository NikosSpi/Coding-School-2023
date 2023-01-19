using System;

namespace Session06
{

    public class University : Institute { 
        // properties

        public string?[] Students { get; set; }
        public string?[] Courses { get; set; }
        public string?[] Grades { get; set; }
        public string?[] SceduledCourse { get; set; }

        // constructors
        public University()
        {

        }
        public University(string[] students)
        {
            Students = new string[30];
            Students = students;
        }

        public University(string[] students, string[] courses)
        {
            Students = new string[30];
            Students = students;
            Courses = new string[20];
            Courses = courses;
        }
        public University(string[] students, string[] courses, string[] grades)
        {
            Students = new string[30];
            Students = students;
            Courses = new string[20];
            Courses = courses;
            Grades = new string[30];
            Grades = grades;
        }


        // methods
        public void GetStudents()
        {

        }

        public void GetCourses()
        {


        }
        public void GetGrades()
        {


        }
        public void SetSchedule(int courseID, int z)
        {


        }
    }

}
