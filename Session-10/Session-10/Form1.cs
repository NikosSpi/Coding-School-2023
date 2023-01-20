using Session_10.Libs;
using System.ComponentModel.Design.Serialization;

namespace Session_10
{
    public partial class Form1 : Form
    {
        private List<Student> _students;
        private List<Courses> _courses;
        private List<Grades> _grades;
        private List<Schedule> _schedule;

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
            _students = new List<Student>();

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



            _students.Add(student1);
            _students.Add(student2);

            bsStudents.DataSource = _students;
        }
       
        private void PopulateCourses()
        {
            _courses = new List<Courses>();

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



            _courses.Add(courses1);
            _courses.Add(courses2);

            bsCourses.DataSource = _courses;
        }

        private void PopulateGrades()
        {
             _grades = new List<Grades>();

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

            _grades.Add(grades1);
            _grades.Add(grades2);

            bsGrades.DataSource = _grades;
        }

        private void PopulateSchedule() {
            _schedule = new List<Schedule>();

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

            _schedule.Add(schedule1);
            _schedule.Add(schedule2);

            bsSchedule.DataSource = _schedule;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_students, "students.json");
            serializer.SerializeToFile(_courses, "students.json");
            serializer.SerializeToFile(_grades, "students.json");
            serializer.SerializeToFile(_schedule, "students.json");
        }
    }
}