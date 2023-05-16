using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;




namespace TDD.Tests
{

    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void TestBubbleSort1()
        {
            // test is to verify the correctness of the BubbleSort method in the StudentViewForm
            List<Student> StudentsTest = new List<Student>();

            int[] grade1 = { 10, 10, 10, 10, 20 };
            var T1 = new TDD.Student("1", "mama", "momo", "mama_momo1@walla.com", "050334551", grade1);
            float avg1 = T1.getAvg();

            int[] grade2 = { 10, 10, 10, 10, 30 };
            var T2 = new TDD.Student("2", "mama", "momo", "mama_momo2@walla.com", "050334551", grade2);
            float avg2 = T2.getAvg();

            int[] grade3 = { 10, 10, 10, 10, 40 };
            var T3 = new TDD.Student("3", "mama", "momo", "mama_mom3o@walla.com", "050334551", grade3);
            float avg3 = T3.getAvg();


            StudentsTest.Add(T1);
            StudentsTest.Add(T2);
            StudentsTest.Add(T3);

            object[] testArray = new object[3];
            testArray = StudentsTest.ToArray();

            StudentViewForm testForm = new StudentViewForm();
            //StudentsTest= testForm.BubbleSort(StudentsTest);

            object[] myArray = new object[3];
            myArray[0] = T1;
            myArray[1] = T2;
            myArray[2] = T3;

            CollectionAssert.AreEqual(myArray, StudentsTest);
        }

        [TestMethod]
        public void QuickSort_SortsAveragesInAscendingOrder()
        {
            // checks if the student are sorted in ascending order

            List<Student> students = new List<Student>();

            int[] grades;
            for (int i = 0; i < 10000; i++)
            {
                string id = Faker.NumberFaker.Number(100000000, 999999999).ToString();
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.InternetFaker.Email();
                string phone = "05" + Faker.NumberFaker.Number(1, 9).ToString() + "-" +
                    Faker.NumberFaker.Number(1000000, 9999999).ToString();

                // TODO : if grade is missing , the grade is 777 . add this to grade generation 
                grades = new int[5];
                for (int j = 0; j < grades.Length; j++)
                    grades[j] = Faker.NumberFaker.Number(0, 101);

                students.Add(new Student(id, firstName, lastName, email, phone, grades));
            }

            StudentViewForm.QuickSort(students, 0, students.Count - 1);

            for (int i = 0; i < students.Count - 1; i++)
            {
                Student currentStudent = students[i];
                Student nextStudent = students[i + 1];

                // Compare currentStudent with nextStudent
                if (currentStudent.getAvg() < nextStudent.getAvg())
                {

                    Console.WriteLine(currentStudent.getFirstName() + " has a higher average than " + nextStudent.getAvg());
                    Assert.Fail("Assertion failed");
                }
                else if (currentStudent.getAvg() >= nextStudent.getAvg())
                {
                    Console.WriteLine(nextStudent.getFirstName() + " has a higher average than " + currentStudent.getFirstName());


                }
                else 
                {
                    Assert.Fail("Assertion failed");
                }
            }
        }

        [TestMethod]
        public void BubbleSort_SortsAveragesInAscendingOrder()
        {
            // checks if the student are sorted in ascending order

            List<Student> students = new List<Student>();

            int[] grades;
            for (int i = 0; i < 10000; i++)
            {
                string id = Faker.NumberFaker.Number(100000000, 999999999).ToString();
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.InternetFaker.Email();
                string phone = "05" + Faker.NumberFaker.Number(1, 9).ToString() + "-" +
                    Faker.NumberFaker.Number(1000000, 9999999).ToString();

                // TODO : if grade is missing , the grade is 777 . add this to grade generation 
                grades = new int[5];
                for (int j = 0; j < grades.Length; j++)
                    grades[j] = Faker.NumberFaker.Number(0, 101);

                students.Add(new Student(id, firstName, lastName, email, phone, grades));
            }

            StudentViewForm.QuickSort(students, 0, students.Count - 1);

            for (int i = 0; i < students.Count - 1; i++)
            {
                Student currentStudent = students[i];
                Student nextStudent = students[i + 1];

                // Compare currentStudent with nextStudent
                if (currentStudent.getAvg() < nextStudent.getAvg())
                {

                    Console.WriteLine(currentStudent.getFirstName() + " has a higher average than " + nextStudent.getAvg());
                    Assert.Fail("Assertion failed");
                }
                else if (currentStudent.getAvg() >= nextStudent.getAvg())
                {
                    Console.WriteLine(nextStudent.getFirstName() + " has a higher average than " + currentStudent.getFirstName());


                }
                else
                {
                    Assert.Fail("Assertion failed");
                }
            }
        }





    }
}
