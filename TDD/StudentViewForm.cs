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
        public WelcomeForm welcomeForm;
        public StudentViewForm(WelcomeForm welcomeForm)
        {
            InitializeComponent();
            
            this.welcomeForm = welcomeForm;
        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {

        }

        /* v1 ---------------------------------------------------------------
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
        --------------------------------------------------------------- */

        /* v2 ---------------------------------------------------------------
        public static double BubbleSort() 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < welcomeForm.Students.Count - 1; i++)
            {
                for (int j = 0; j < welcomeForm.Students.Count - i - 1; j++)
                {
                    if (welcomeForm.Students[j].getAvg() < welcomeForm.Students[j + 1].getAvg())
                    {
                        Student temp = welcomeForm.Students[j];
                        welcomeForm.Students[j] = welcomeForm.Students[j + 1];
                        welcomeForm.Students[j + 1] = temp;
                    }
                }          
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalMilliseconds;
        }
        --------------------------------------------------------------- */

        // updated (and fastest) sorting method
        public static double QuickSort(List<Student> students, int left, int right)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            if (left < right)
            {
                int pivot = Partition(students, left, right);
                QuickSort(students, left, pivot - 1);
                QuickSort(students, pivot + 1, right);
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalMilliseconds;
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

        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            QuickSortLabel.Text = QuickSort(welcomeForm.Students, 0, welcomeForm.Students.Count - 1).ToString();
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
            for (int i = 0; i < welcomeForm.Students.Count; i++)
            {
                Student student = welcomeForm.Students[i];
                grades = student.getGrades();
                studentsTable.Rows.Add(i + 1, student.getId(), student.getFirstName(), student.getLastName(), student.getEmail(), student.getPhone(),
                                    student.getAvg(), grades[0], grades[1], grades[2], grades[3], grades[4]);
            }

            welcomeForm.studentsTable = studentsTable;
            StudentGridView.DataSource = welcomeForm.studentsTable;
        }

        public void setTableDataSource(DataTable studentsTable) { StudentGridView.DataSource=studentsTable; }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
