using System;

namespace Session06
{

    public class Professor : Person
    {
        // properties

        public string? Rank { get; set; }
        public string?[] Courses { get; set; }

        // constructors
        public Professor()
        {

        }
        public Professor(string rank)
        {
            Rank = rank;
        }

        public Professor(string rank, string[] courses)
        {
            Rank = rank;
            Courses = new string[5];
            Courses = courses;
        }


        // methods
        public void Teach(string[] courses, DateTime dateTime)
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grades)
        {


        }

    }
}
