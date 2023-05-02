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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void StudentViewButton_Click(object sender, EventArgs e)
        {

            // check before if theres already an open student view form
            StudentViewForm studentViewForm = new StudentViewForm();
            studentViewForm.ShowDialog();
        }
    }
}
