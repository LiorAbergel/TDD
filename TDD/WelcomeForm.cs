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
        
        public WelcomeForm()
        {
            InitializeComponent();



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
            // make the welcome form close before opening the new form
            StudentViewForm studentViewForm = new StudentViewForm();  
            studentViewForm.ShowDialog();
            
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
