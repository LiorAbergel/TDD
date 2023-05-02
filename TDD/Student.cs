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
