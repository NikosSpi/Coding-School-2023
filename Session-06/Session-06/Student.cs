using System;

namespace Session06
{

    public class Student : Person
    {
        // properties

        public int RegistrationNumber { get; set; }
        public string?[] Courses { get; set; }

        // constructors
        public Student()
        {

        }
        public Student(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public Student(int registrationNumber, string[] courses)
        {
            RegistrationNumber = registrationNumber;
            Courses = new string[20];
            Courses = courses;
        }


        // methods
        public void Attend(string[] courses, DateTime dateTime)
        {

        }

        public void WriteExam(string[] courses, DateTime dateTime)
        {


        }
    }

}
