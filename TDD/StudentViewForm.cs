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
        public StudentViewForm()
        {
            InitializeComponent();

            StudentGridView.DataSource = WelcomeForm.studentsTable;
        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // check before if theres already an open add student form
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
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

        public DataGridView getStudentGridView() { return  StudentGridView; }
    }
}
