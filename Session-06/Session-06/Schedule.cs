using System;

namespace Session06
{

    public class Schedule
    {

        // properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProffesorID { get; set; }
        public DateTime Callendar { get; set; }


        // constructors
        public Schedule()
        {

        }

        public Schedule(Guid id)
        {
            ID = id;
        }

        public Schedule(Guid id, Guid courseid)
        {
            ID = id;
            CourseID = courseid;
        }
        public Schedule(Guid id, Guid courseid, Guid proffesorid)
        {
            ID = id;
            CourseID = courseid;
            ProffesorID = proffesorid;
        }
        public Schedule(Guid id, Guid courseid, Guid proffesorid, DateTime callendar)
        {
            ID = id;
            CourseID = courseid;
            ProffesorID = proffesorid;
            Callendar = callendar;
        }
    }
}



