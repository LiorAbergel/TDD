using System;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //int.TryParse is used to attempt to convert each element of the string array to an integer.
            //If the conversion is successful, the converted value is stored in the corresponding element of the int array.
            //If the conversion fails, an error message is displayed and the program exits

            string[] stringArray = { Grade1Box.Text, Grade2Box.Text, Grade3Box.Text,
                Grade4Box.Text, Grade5Box.Text };

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (int.TryParse(stringArray[i], out intArray[i]))
                {
                    // the parsing was successful and was converted into the array of int grades, continue
                }
                else
                {
                    // handle invalid input because of an unexpected value
                    MessageBox.Show("Invalid input: " + stringArray[i]);
                    return;
                }
            }
        }
    }
}
