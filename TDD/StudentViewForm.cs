using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class StudentViewForm : Form
    {
        public static List<Student> Students = new List<Student>();
        public StudentViewForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int i = 0; i < 10000; i++)
            {
                string id = Faker.NumberFaker.Number(100000000, 999999999).ToString();
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.InternetFaker.Email();
                string phone = "05" + Faker.NumberFaker.Number(1, 9).ToString() + "-" +
                    Faker.NumberFaker.Number(1000000, 9999999).ToString();

                // TODO : if grade is missing , the grade is 777 . add this to grade generation 
                int[] grades = new int[5];
                for (int j = 0; j < grades.Length; j++)
                    grades[j] = Faker.NumberFaker.Number(0, 101);

                Students.Add(new Student(id, firstName, lastName, email, phone, grades));
            }

            for (int i = 0; i < StudentViewForm.Students.Count; i++)
            {
                Student student = StudentViewForm.Students[i];

                int[] grades = student.getGrades();
                StudentViewTable.Rows.Add(
                    i + 1,
                    student.getId(),
                    student.getFirstName(),
                    student.getLastName(),
                    student.getEmail(),
                    student.getPhone(),
                    student.getAvg(),
                    grades[0],
                    grades[1],
                    grades[2],
                    grades[3],
                    grades[4]
                );
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // check before if theres already an open add student form
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<Student> BubbleSort(List<Student> Students) 
        {
            // a sorting algorithem that sorts the average grades of students
            for (int i = 0; i < Students.Count - 1; i++)
            {
                for (int j = 0; j < Students.Count - i - 1; j++)
                {
                    if (Students[j].getAvg() >  Students[j + 1].getAvg())
                    {
                        Student temp = Students[j];
                        Students[j] = Students[j + 1];
                        Students[j + 1] = temp;
                    }
                }          
            }
            Console.WriteLine(DateTime.Now.Millisecond);
            return Students;
        }
    }
}
