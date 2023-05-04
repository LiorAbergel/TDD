using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private int[] grade = new int[5];
        private float avg;
        
        public Student() {}
        public Student(int id, string firstName, string lastName, string email, string phone, int[] grade)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.grade = grade;
            calculateAvg();
        }


        public void setId(int id) { this.id = id; }
        public void setFirstName(string name) { this.firstName = name; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setEmail(string email) { this.firstName = email; }
        public void setGrade(int[] grade) { this.grade = grade; }
        public void setPhone(string phone) { this.phone = phone; }

        public int getId() { return id; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getEmail() { return email; }
        public int[] getGrade() { return grade; }
        public string getPhone() { return phone; }
        public float getAvg() { return avg; }
        private void calculateAvg()
        {
            int sum = 0;
            int amountOfGrades = 0;
            for (int i = 0; i < 5; i++)
            {
                if (grade[i] != 777)
                {
                    sum += grade[i];
                    amountOfGrades++;
                }
            }
            avg = sum / amountOfGrades;
        }

    }
}
