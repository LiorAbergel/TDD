using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Faker;


namespace TDD
{
    public partial class WelcomeForm : Form
    {
        public StudentViewForm studentViewForm;
        public AddStudentForm addStudentForm;
        public List<Student> Students;
        public DataTable studentsTable; 

        public WelcomeForm()
        {
            InitializeComponent();

            studentViewForm = new StudentViewForm(this);
            addStudentForm = new AddStudentForm(this);

            Students = new List<Student>();

            int i;
            int[] grades;
            bool hasGrade;
            Random random = new Random();
            for (i = 0; i < 10000; i++)
            {
                string id = Faker.NumberFaker.Number(100000000, 999999999).ToString();
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.InternetFaker.Email();
                string phone = "05" + Faker.NumberFaker.Number(1, 9).ToString() + "-" +
                    Faker.NumberFaker.Number(1000000, 9999999).ToString();

                grades = new int[5];
                for (int j = 0; j < grades.Length; j++)
                {
                    // there's a 98 % chance the current grade will be null (777)
                    hasGrade = random.NextDouble() < 0.98;
                    if (hasGrade)
                        grades[j] = Faker.NumberFaker.Number(0, 101);
                    else
                        grades[j] = 777;
                }

                Students.Add(new Student(id, firstName, lastName, email, phone, grades));
            }

            studentsTable = new DataTable();

            studentsTable.Columns.Add("Index", typeof(int));
            studentsTable.Columns.Add("ID", typeof(string));
            studentsTable.Columns.Add("First Name", typeof(string));
            studentsTable.Columns.Add("Last Name", typeof(string));
            studentsTable.Columns.Add("Email", typeof(string));
            studentsTable.Columns.Add("Phone", typeof(string));
            studentsTable.Columns.Add("Average", typeof(string));
            studentsTable.Columns.Add("Algorithms I", typeof(int));
            studentsTable.Columns.Add("Statistics", typeof(int));
            studentsTable.Columns.Add("Advanced OOP", typeof(int));
            studentsTable.Columns.Add("Data Structures", typeof(int));
            studentsTable.Columns.Add("Software Testing & Quality", typeof(int));

            for (i = 0; i < Students.Count;i++)
            {
                Student student = Students[i];
                grades = student.getGrades();
                studentsTable.Rows.Add(i + 1, student.getId(), student.getFirstName(), student.getLastName(), student.getEmail(), student.getPhone(),
                                    student.getAvg(), grades[0], grades[1], grades[2], grades[3], grades[4]);
            }

            studentViewForm.setTableDataSource(studentsTable);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            addStudentForm.ShowDialog();
        }

        private void StudentViewButton_Click(object sender, EventArgs e)
        {
            studentViewForm.ShowDialog();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }



    }
}

