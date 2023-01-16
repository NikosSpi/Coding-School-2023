using System;

namespace Session06
{

    public class Grade
    {

        // properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grades { get; set; }

        // constructors
        public Grade()
        {

        }

        public Grade(Guid id)
        {
            ID = id;
        }

        public Grade(Guid id, Guid studentid)
        {
            ID = id;
            StudentID = studentid;
        }

        public Grade(Guid id, Guid studentid, Guid courseid)
        {
            ID = id;
            StudentID = studentid;
            CourseID= courseid;
        }
        public Grade(Guid id, Guid studentid, Guid courseid, int grades)
        {
            ID = id;
            StudentID = studentid;
            CourseID = courseid;
            Grades = grades;
        }
    }
}



