using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace TDD
{
    public partial class AddStudentForm : Form
    {
        public static int studentsAdded = 10000;
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
            }
            if (emptyTextBoxFound)
                MessageBox.Show("One or more text boxes are empty. Please fill them in.");
              
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

            // TODO : add personalized message if length not valid , and if input contains letters or symobls
            string id = IDBox.Text;
            if (Regex.IsMatch(id, @"^\d{9}$"))
            {
                newStud.setId(id);
            }
            else
            {
                // handle invalid input because of an unexpected value
                MessageBox.Show("Invalid input of id: " + IDBox.Text);
                return;
            }

            string firstName = FirstNameBox.Text;
            if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                newStud.setFirstName(firstName);
            }
            else
            {
                // handle invalid input because of an unexpected value
                MessageBox.Show("Invalid input of First Name: " + firstName);
                return;
            }

            string lastName = LastNameBox.Text;
            if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                newStud.setLastName(lastName);
            }
            else
            {
                // handle invalid input because of an unexpected value
                MessageBox.Show("Invalid input of Last Name: " + lastName);
                return;
            }

            string email = EmailBox.Text;
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                newStud.setEmail(email);
            }
            else
            {
                // handle invalid input because of an unexpected value
                MessageBox.Show("Invalid input of Email: " + email);
                return;
            }


            // TODO : fix personalized message in phone checking
            string phone = PhoneBox.Text; // example phone number
            Regex regex = new Regex(@"^05[0-9]{8}$"); // regular expression for the desired format
            if (regex.IsMatch(phone))
            {
                // the phone number is in the desired format, add "-" after the third number if not already present
                if (phone.Length == 10)
                {
                    phone = phone.Insert(3, "-");
                    newStud.setPhone(phone);
                }
                else
                {
                    // handle error: phone number is not 10 digits long
                    MessageBox.Show("Invalid input of Phone: " + phone + ". The number is not 10 digits long .");
                    return;
                }
            }
            else
            {
                // handle error: phone number is not in the desired format
                MessageBox.Show("Invalid input of Phone: " + phone);
                return;
            }


            // TODO : if grade was not added , accept the input and put 777 instead
            string[] stringGradeArray = { Grade1Box.Text, Grade2Box.Text, Grade3Box.Text,
                Grade4Box.Text, Grade5Box.Text };

            int[] intGradeArray = new int[stringGradeArray.Length];

            for (int i = 0; i < stringGradeArray.Length; i++)
            {
                if (int.TryParse(stringGradeArray[i], out intGradeArray[i]))
                {
                    // the parsing was successful and was converted into the array of int grades, continue
                    
                }
                else
                {
                    // handle invalid input because of an unexpected value
                    MessageBox.Show("Invalid input: " + stringGradeArray[i]);
                    return;
                }
                if (intGradeArray[i] != 777 && intGradeArray[i]> 100)
                {
                    MessageBox.Show("Invalid input: " + stringGradeArray[i] +" is above 100");
                    return;
                }
                else if (intGradeArray[i] < 0)
                {
                    MessageBox.Show("Invalid input: " + stringGradeArray[i] + " is below 0");
                    return;
                }
  
            }         
            newStud.setGrade(intGradeArray);     
            
            WelcomeForm.Students.Add(newStud);

            studentsAdded++;
            WelcomeForm.studentsTable.Rows.Add(studentsAdded, newStud.getId(), newStud.getFirstName(), newStud.getLastName(), newStud.getEmail(), newStud.getPhone(),
                intGradeArray[0], intGradeArray[1], intGradeArray[2], intGradeArray[3], intGradeArray[4]);

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
