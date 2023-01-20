namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grvStudents.AutoGenerateColumns = false;
            grvCourses.AutoGenerateColumns = false;
            grvGrades.AutoGenerateColumns = false;
            grvSchedule.AutoGenerateColumns = false;

            PopulateStudent();

            PopulateCourses();

            PopulateGrades();

            PopulateSchedule();

            

            

        }

        private void PopulateStudent()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Name = "Nikos",
                Surname = "Spiliopoulos",
                Age = 30
            };
            Student student2 = new Student()
            {
                Name = "Antreas",
                Surname = "Papas",
                Age = 28
            };



            students.Add(student1);
            students.Add(student2);

            bsStudents.DataSource = students;
        }
       
        private void PopulateCourses()
        {
            List<Courses> courses = new List<Courses>();

            Courses courses1 = new Courses()
            {
                Lesson = "CodeSchool",
                Teacher = "Fotis Chrysoulas"
            };
            Courses courses2 = new Courses()
            {
                Lesson = "Programming",
                Teacher = "Dimitris Raptodimos"
            };



            courses.Add(courses1);
            courses.Add(courses2);

            bsCourses.DataSource = courses;
        }

        private void PopulateGrades()
        {
            List<Grades> grades = new List<Grades>();

            Grades grades1 = new Grades()
            {
                Lesson = "CodeSchool",
                Teacher = "Fotis Chrysoulas",
                Grade = "93%"
            };
            Grades grades2 = new Grades()
            {
                Lesson = "Programming",
                Teacher = "Dimitris Raptodimos",
                Grade = "95%"
            };

            grades.Add(grades1);
            grades.Add(grades2);

            bsGrades.DataSource = grades;
        }

        private void PopulateSchedule() {
            List<Schedule> schedule = new List<Schedule>();

            Schedule schedule1 = new Schedule()
            {
                Lesson = "CodeSchool",
                Teacher = "Fotis Chrysoulas",
                DateTime = "22/1/2023"
            };
            Schedule schedule2 = new Schedule()
            {
                Lesson = "Programming",
                Teacher = "Dimitris Raptodimos",
                DateTime = "23/1/2023"
            };

            schedule.Add(schedule1);
            schedule.Add(schedule2);

            bsSchedule.DataSource = schedule;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Courses_Click(object sender, EventArgs e)
        {

        }

        private void bsStudents_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}