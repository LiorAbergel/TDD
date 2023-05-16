using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();

        }

        /* v1
        public List<Student> BubbleSort(List<Student> students)
        {
            for (int i = 0; i < Students.Count - 1; i++)
            {
                for (int j = 0; j < Students.Count - i - 1; j++)
                {
                    if (Students[j].getAvg() > Students[j + 1].getAvg())
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
        */

        public List<Student> BubbleSort() 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            // a sorting algorithem that sorts the average grades of students
            for (int i = 0; i < WelcomeForm.Students.Count - 1; i++)
            {
                for (int j = 0; j < WelcomeForm.Students.Count - i - 1; j++)
                {
                    if (WelcomeForm.Students[j].getAvg() < WelcomeForm.Students[j + 1].getAvg())
                    {
                        Student temp = WelcomeForm.Students[j];
                        WelcomeForm.Students[j] = WelcomeForm.Students[j + 1];
                        WelcomeForm.Students[j + 1] = temp;
                    }
                }          
            }
            stopwatch.Stop();
            BubbleSortLabel.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
            return WelcomeForm.Students;
        }

        public  List<Student> QuickSort(List<Student> students, int left, int right)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            if (left < right)
            {
                int pivot = Partition(students, left, right);
                QuickSort(students, left, pivot - 1);
                QuickSort(students, pivot + 1, right);
            }

            stopwatch.Stop();
            QuickSortLabel.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();

            return students;
        }

        public static int Partition(List<Student> students, int left, int right)
        {
            float pivotValue = students[right].getAvg();
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (students[j].getAvg() > pivotValue)
                {
                    i++;
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
            Student temp2 = students[i + 1];
            students[i + 1] = students[right];
            students[right] = temp2;
            return i + 1;
        }


        public DataGridView getStudentGridView() { return  StudentGridView; }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            List<Student> students= BubbleSort();
            setStudentsGridView();
        }

        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            List<Student>  students = QuickSort(WelcomeForm.Students, 0, WelcomeForm.Students.Count - 1);
            setStudentsGridView();
        }

        private void setStudentsGridView()
        {
            DataTable studentsTable = new DataTable();

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


            int[] grades;
            for (int i = 0; i < WelcomeForm.Students.Count; i++)
            {
                Student student = WelcomeForm.Students[i];
                grades = student.getGrades();
                studentsTable.Rows.Add(i + 1, student.getId(), student.getFirstName(), student.getLastName(), student.getEmail(), student.getPhone(),
                                    student.getAvg(), grades[0], grades[1], grades[2], grades[3], grades[4]);
            }

            WelcomeForm.setDataTable(studentsTable);
            StudentGridView.DataSource = WelcomeForm.studentsTable;
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
