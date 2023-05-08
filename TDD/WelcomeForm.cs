using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Faker;


namespace TDD
{
    public partial class WelcomeForm : Form
    {   
        public static List<Student> Students = new List<Student>();
        public WelcomeForm()
        {
            InitializeComponent();


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

                Students.Add(new Student(id, firstName, lastName, email, phone,grades));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void StudentViewButton_Click(object sender, EventArgs e)
        {
            StudentViewForm studentViewForm = new StudentViewForm();
            studentViewForm.ShowDialog();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
