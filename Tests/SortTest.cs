using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;




namespace TDD.Tests
{

    [TestClass]
    public class SortTest
    {
        /* ------------------------------------------------------
        [TestMethod]
        public void BubbleSort_SortsAveragesInAscendingOrder()
        {
            // checks if the student are sorted in ascending order after using the BubbleSort method

            WelcomeForm testWelcomeForm = new WelcomeForm();
            StudentViewForm testStudentViewForm = new StudentViewForm(testWelcomeForm);

            testStudentViewForm.BubbleSort();

            for (int i = 0; i < testWelcomeForm.Students.Count - 1; i++)
            {
                Student currentStudent = testWelcomeForm.Students[i];
                Student nextStudent = testWelcomeForm.Students[i + 1];

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

        public void BubbleSort_AnyLostEntries()
        {
            List<Student> students = new List<Student>();
            students.Add(new TDD.Student("1", "mama", "momo", "mama_momo@walla.com", "050334551", new int[] { 100, 100, 100, 100, 100 }));
            students.Add(new TDD.Student("2", "mama", "momi", "mama_momi@walla.com", "050334552", new int[] { 90, 90, 90, 90, 90 }));
            students.Add(new TDD.Student("3", "mama", "momu", "mama_momu@walla.com", "050334553", new int[] { 80, 80, 80, 80, 80 }));
            List<Student> sortedStudents = new List<Student>(students);

            StudentViewForm.BubbleSort();

            for (int i = 0; i < sortedStudents.Count - 1; i++)
            {
                Assert.AreEqual(students[i], sortedStudents[i], "Some students were lost or duplicated during sorting.");
            }

        }
         ------------------------------------------------------ */



        [TestMethod]
        public void QuickSort_SortsAveragesInAscendingOrder()
        {
            // checks if the student are sorted in ascending order after using the QuickSort method

            WelcomeForm testWelcomeForm = new WelcomeForm();

            StudentViewForm.QuickSort(testWelcomeForm.Students, 0, testWelcomeForm.Students.Count - 1);

            for (int i = 0; i < testWelcomeForm.Students.Count - 1; i++)
            {
                Student currentStudent = testWelcomeForm.Students[i];
                Student nextStudent = testWelcomeForm.Students[i + 1];

                // Compare currentStudent with nextStudent
                if (currentStudent.getAvg() < nextStudent.getAvg())
                {
                    Assert.Fail($"{currentStudent.getFirstName()} {currentStudent.getLastName()} (index: {i}) average is {currentStudent.getAvg()} ," +
                        $" {nextStudent.getFirstName()} {nextStudent.getLastName()} (index: {i}) average is {nextStudent.getAvg()}");
                }
                else if (currentStudent.getAvg() >= nextStudent.getAvg())
                {
                    continue;
                }
                else
                {
                    Assert.Fail("Assertion failed");
                }
            }
        }

        [TestMethod]
        public void QuickSort_AnyLostEntries()
        {
            List<Student> students = new List<Student>();
            students.Add(new TDD.Student("1", "mama", "momo", "mama_momo@walla.com", "050334551",new int[] { 100, 100, 100, 100, 100 }));
            students.Add(new TDD.Student("2", "mama", "momi", "mama_momi@walla.com", "050334552", new int[] { 90, 90, 90, 90, 90 }));
            students.Add(new TDD.Student("3", "mama", "momu", "mama_momu@walla.com", "050334553", new int[] { 80, 80, 80, 80, 80 }));
            List<Student> sortedStudents = new List<Student>(students);


            StudentViewForm.QuickSort(sortedStudents, 0, students.Count - 1);

            for (int i = 0; i < sortedStudents.Count - 1; i++)
            {
                Assert.AreEqual(students[i], sortedStudents[i], "Some students were lost or duplicated during sorting.");
            }

        }
    }
}
