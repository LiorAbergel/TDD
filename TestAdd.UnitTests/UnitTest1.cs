using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAdd.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var T = new Student
            int[] grade = { 10, 10, 10, 10, 10 };
            float avg;
            float expected_avg = 10;
            int sum = 0;
            for (int i = 0; i < 5; i++)
                sum += grade[i];
            avg = sum / 5;
            Assert.AreEqual(expected_avg, avg);
        }
    }
}
