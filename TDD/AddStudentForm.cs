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

        private bool CheckIfTextBoxesEmpty(Control parent)
        {
            //This method takes a Control object,
            //which represents the parent container for all your text boxes (e.g. a form or a panel).
            //It then iterates over all the controls in the container and checks if each control
            //is a TextBox and if its Text property is empty or null.
            //If it finds an empty text box, it sets a flag to indicate that and breaks out of the loop.

            bool emptyTextBoxFound = false;
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    emptyTextBoxFound = true;
                    break;
                }
                if (control.Controls.Count > 0)
                {
                    emptyTextBoxFound = CheckIfTextBoxesEmpty(control);
                    if (emptyTextBoxFound)
                    {
                        break;
                    }
                }
            }
            if (emptyTextBoxFound)
            {
                MessageBox.Show("One or more text boxes are empty. Please fill them in.");
              
            }
            return emptyTextBoxFound;
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


            
            if (CheckIfTextBoxesEmpty(this)) return;


            Student newStud = new Student();

            string[] stringArray = { Grade1Box.Text, Grade2Box.Text, Grade3Box.Text,
                Grade4Box.Text, Grade5Box.Text };

            int[] GradeArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (int.TryParse(stringArray[i], out GradeArray[i]))
                {
                    // the parsing was successful and was converted into the array of int grades, continue
                    
                }
                else
                {
                    // handle invalid input because of an unexpected value
                    MessageBox.Show("Invalid input: " + stringArray[i]);
                    return;
                }
                if (GradeArray[i] != 777 && GradeArray[i]> 100)
                {
                    MessageBox.Show("Invalid input: " + stringArray[i] +" is above 100");
                    return;
                }
                else if (GradeArray[i] < 0)
                {
                    MessageBox.Show("Invalid input: " + stringArray[i] + " is below 0");
                    return;
                }
  
            }         
            newStud.setGrade(GradeArray);        
            
            /*
            int ConvertedIntToString;

            if (int.TryParse(IDBox.Text, out ConvertedIntToString))
            {
                // the parsing was successful and was converted into the int id
                newStud.setId(ConvertedIntToString);
            }
            else
            {
                // handle invalid input because of an unexpected value
                MessageBox.Show("Invalid input of id: " + IDBox.Text);
                return;
            }
            */

        }


        bool CheckPhoneNumValidaion(string phoneNum) { return true; }

        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if((!char.IsNumber(e.KeyChar))&& (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Grade1Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Grade2Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Grade3Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Grade4Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Grade5Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes they key box accept only numbers
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
