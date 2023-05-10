using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class CalcAvgTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] grade = { 10, 10, 10, 10, 10 };
            var T = new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float avg = T.getAvg();
            float expected_avg = 10;
            Assert.AreEqual(expected_avg, avg);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] grade = { 10, 10, 10, 10, 10 };
            var T = new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float avg = T.getAvg();
            float expected_avg = 15;
            Assert.AreNotEqual(expected_avg, avg);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Random rand = new Random();
            int amountOfGrades = 0;
            int sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                int[] grade = { rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100) };
                var T = new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
                float avg = T.getAvg();
                float expected_avg = (grade[0] + grade[1] + grade[2] + grade[3] + grade[4]) / 5;
                Assert.AreEqual(expected_avg, avg);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            Random rand = new Random();
            int amountOfGrades = 0;
            int sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                int[] grade = { rand.Next(0, 100), rand.Next(0, 100), 777, rand.Next(0, 100), rand.Next(0, 100) };
                var T = new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
                float avg = T.getAvg();
                for (int j = 0; j < 5; j++)
                {
                    if (grade[j] != 777)
                    {
                        sum += grade[j];
                        amountOfGrades++;
                    }
                }
                float expectedAvd = sum / amountOfGrades;
                Assert.AreEqual(expectedAvd, avg);
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            Random rand = new Random();
            int amountOfGrades = 0;
            int sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                int[] grade = new int[5];
                var T = new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
                Assert.ThrowsException;
            }
        }
        [TestMethod]
        public void TestMethod6()
        {
            Random rand = new Random();
            int amountOfGrades = 0;
            int sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                int[] grade = { "Hi!", "It", "was", "me,", "Dio!" };
                Assert.ThrowsException<ArgumentException>(() => new TDD.Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade));

            }
        }
    }
}
