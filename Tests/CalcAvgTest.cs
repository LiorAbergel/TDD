using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD.Tests
{
    [TestClass]
    public class CalcAvgTest
    {

        [TestMethod]
        public void GetAvg_ReturnsCorrectAverage()
        {
            int[] grade = { 10, 10, 10, 10, 10 };
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 10;

            float actualAvg = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAvg, "The average is not calculated correctly.");
        }

        [TestMethod]
        public void GetAvg_ReturnsIncorrectAverage()
        {
            int[] grade = { 10, 10, 10, 10, 10 };
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 15;

            float actualAvg = T.getAvg();

            Assert.AreNotEqual(expectedAvg, actualAvg, "The average is not calculated correctly.");
        }

        [TestMethod]
        public void GetAvg_RandomGrades()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int[] grade = { rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100) };
                var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
                float actualAverage = T.getAvg();

                float expectedAvg = (grade[0] + grade[1] + grade[2] + grade[3] + grade[4]) / 5;

                Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly.");
            }
        }

        [TestMethod]
        public void GetAvg_AllGradesAre777_ReturnsZero()
        {
            int[] grade = { 777, 777, 777, 777, 777 };
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 0;

            float actualAverage = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly when all grades are 777.");
        }

        [TestMethod]
        public void GetAvg_AllGradesAreNegative_ReturnsZero()
        {
            int[] grade = { -1, -1, -1, -1, -1};
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 0;

            float actualAverage = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly when all grades are negative.");
        }

        [TestMethod]
        public void GetAvg_AllGradesAreAbove100_ReturnsZero()
        {
            int[] grade = { 101, 101, 101, 101, 101 };
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 0;

            float actualAverage = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly when all grades are above 100.");
        }

        [TestMethod]
        public void GetAvg_OnlyOneGrade_ReturnsGrade()
        {
            int[] grade = { 10};
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 10;

            float actualAverage = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly when there's only one grade.");
        }

        [TestMethod]
        public void GetAvg_EmptyArray_Returns0()
        {
            int[] grade = {};
            var T = new Student("123456", "mama", "momo", "mama_momo@walla.com", "050334551", grade);
            float expectedAvg = 0;

            float actualAverage = T.getAvg();

            Assert.AreEqual(expectedAvg, actualAverage, "The average is not calculated correctly when there's no grades.");
        }
    }
}
