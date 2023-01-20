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

            grvStudents.DataSource= students;   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}