namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtStudents = new System.Windows.Forms.Label();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.colTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCourses = new System.Windows.Forms.Label();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLessonGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrades = new System.Windows.Forms.Label();
            this.grvSchedule = new System.Windows.Forms.DataGridView();
            this.txtSchedule = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colAge});
            this.grvStudents.Location = new System.Drawing.Point(215, 1);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowHeadersWidth = 51;
            this.grvStudents.RowTemplate.Height = 29;
            this.grvStudents.Size = new System.Drawing.Size(586, 102);
            this.grvStudents.TabIndex = 0;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.MinimumWidth = 6;
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 200;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Width = 125;
            // 
            // txtStudents
            // 
            this.txtStudents.AutoSize = true;
            this.txtStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStudents.Location = new System.Drawing.Point(79, 1);
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.Size = new System.Drawing.Size(92, 28);
            this.txtStudents.TabIndex = 1;
            this.txtStudents.Text = "Students";
            this.txtStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // grvCourses
            // 
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacher,
            this.colLesson});
            this.grvCourses.Location = new System.Drawing.Point(215, 109);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowHeadersWidth = 51;
            this.grvCourses.RowTemplate.Height = 29;
            this.grvCourses.Size = new System.Drawing.Size(586, 107);
            this.grvCourses.TabIndex = 2;
            // 
            // colTeacher
            // 
            this.colTeacher.DataPropertyName = "Teacher";
            this.colTeacher.HeaderText = "Teacher";
            this.colTeacher.MinimumWidth = 6;
            this.colTeacher.Name = "colTeacher";
            this.colTeacher.Width = 350;
            // 
            // colLesson
            // 
            this.colLesson.DataPropertyName = "Lesson";
            this.colLesson.HeaderText = "Lesson";
            this.colLesson.MinimumWidth = 6;
            this.colLesson.Name = "colLesson";
            this.colLesson.Width = 200;
            // 
            // txtCourses
            // 
            this.txtCourses.AutoSize = true;
            this.txtCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCourses.Location = new System.Drawing.Point(87, 109);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(84, 28);
            this.txtCourses.TabIndex = 3;
            this.txtCourses.Text = "Courses";
            this.txtCourses.Click += new System.EventHandler(this.Courses_Click);
            // 
            // grvGrades
            // 
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colLessonGrades,
            this.colGrades});
            this.grvGrades.Location = new System.Drawing.Point(215, 222);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowHeadersWidth = 51;
            this.grvGrades.RowTemplate.Height = 29;
            this.grvGrades.Size = new System.Drawing.Size(586, 134);
            this.grvGrades.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn1.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // colLessonGrades
            // 
            this.colLessonGrades.DataPropertyName = "Lesson";
            this.colLessonGrades.HeaderText = "Lesson";
            this.colLessonGrades.MinimumWidth = 6;
            this.colLessonGrades.Name = "colLessonGrades";
            this.colLessonGrades.Width = 200;
            // 
            // colGrades
            // 
            this.colGrades.DataPropertyName = "Grade";
            this.colGrades.HeaderText = "Grade";
            this.colGrades.MinimumWidth = 6;
            this.colGrades.Name = "colGrades";
            this.colGrades.Width = 125;
            // 
            // txtGrades
            // 
            this.txtGrades.AutoSize = true;
            this.txtGrades.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGrades.Location = new System.Drawing.Point(96, 222);
            this.txtGrades.Name = "txtGrades";
            this.txtGrades.Size = new System.Drawing.Size(75, 28);
            this.txtGrades.TabIndex = 5;
            this.txtGrades.Text = "Grades";
            // 
            // grvSchedule
            // 
            this.grvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.colProfessor,
            this.colDateTime});
            this.grvSchedule.Location = new System.Drawing.Point(215, 362);
            this.grvSchedule.Name = "grvSchedule";
            this.grvSchedule.RowHeadersWidth = 51;
            this.grvSchedule.RowTemplate.Height = 29;
            this.grvSchedule.Size = new System.Drawing.Size(586, 90);
            this.grvSchedule.TabIndex = 6;
            // 
            // txtSchedule
            // 
            this.txtSchedule.AutoSize = true;
            this.txtSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSchedule.Location = new System.Drawing.Point(76, 362);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(95, 28);
            this.txtSchedule.TabIndex = 7;
            this.txtSchedule.Text = "Schedule";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lesson";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lesson";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // colProfessor
            // 
            this.colProfessor.DataPropertyName = "Teacher";
            this.colProfessor.HeaderText = "Professor";
            this.colProfessor.MinimumWidth = 6;
            this.colProfessor.Name = "colProfessor";
            this.colProfessor.Width = 250;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "Callendar";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSchedule);
            this.Controls.Add(this.grvSchedule);
            this.Controls.Add(this.txtGrades);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.txtCourses);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.txtStudents);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvStudents;
        private BindingSource bindingSource1;
        private Label txtStudents;
        private DataGridView grvCourses;
        private Label txtCourses;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colTeacher;
        private DataGridViewTextBoxColumn colLesson;
        private DataGridView grvGrades;
        private Label txtGrades;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colLessonGrades;
        private DataGridViewTextBoxColumn colGrades;
        private DataGridView grvSchedule;
        private Label txtSchedule;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn colProfessor;
        private DataGridViewTextBoxColumn colDateTime;
    }
}