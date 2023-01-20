namespace Session_10
{
    public class Student
    {

        public Student()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
    }


    public class University
    {

        public University(Guid id)
        {
            ID = id;
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }
    }
}
