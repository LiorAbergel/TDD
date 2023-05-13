using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
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
            StudentsTest= testForm.BubbleSort(StudentsTest);

            object[] myArray = new object[3];
            myArray[0] = T1;
            myArray[1] = T2;
            myArray[2] = T3;

            CollectionAssert.AreEqual(myArray, StudentsTest);
        }
    }
}
