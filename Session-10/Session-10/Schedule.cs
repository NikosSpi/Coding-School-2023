namespace Session_10
{
    public class Schedule
    {

        public Schedule()
        {
            ID = Guid.NewGuid();
        }



        public Guid ID { get; set; }
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        public string DateTime { get; set; }



    }
}
