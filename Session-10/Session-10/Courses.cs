namespace Session_10
{
    public class Courses
    {

        public Courses()
        {
            ID = Guid.NewGuid();
        }

        

        public Guid ID { get; set; }
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        

    }
}
