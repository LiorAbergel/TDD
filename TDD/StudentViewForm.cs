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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < WelcomeForm.Students.Count; i++)
            {
                Student student = WelcomeForm.Students[i];

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
    }
}
