namespace Session_10
{
    public class Grades
    {

        public Grades()
        {
            ID = Guid.NewGuid();
        }



        public Guid ID { get; set; }
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        public string Grade { get; set; }



    }
}


