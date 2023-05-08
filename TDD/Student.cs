using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Student
    {
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private int[] grades = new int[5];
        private float avg;
        
        public Student() {}
        public Student(string id, string firstName, string lastName, string email, string phone, int[] grades)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.grades = grades;
            calculateAvg();
        }


        public void setId(string id) { this.id = id; }
        public void setFirstName(string name) { this.firstName = name; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setEmail(string email) { this.firstName = email; }
        public void setGrade(int[] grade) { this.grades = grade; }
        public void setPhone(string phone) { this.phone = phone; }

        public string getId() { return id; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getEmail() { return email; }
        public int[] getGrades() { return grades; }
        public string getPhone() { return phone; }
        public float getAvg() { return avg; }
        private void calculateAvg()
        {
            int sum = 0;
            int amountOfGrades = 0;
            for (int i = 0; i < 5; i++)
            {
                if (grades[i] != 777)
                {
                    sum += grades[i];
                    amountOfGrades++;
                }
            }
            avg = sum / amountOfGrades;
        }

        internal void setId(int convertedIntToString)
        {
            throw new NotImplementedException();
        }
    }
}
