using Assign_5_solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = new int[] { 7, 9, 14, 13, 42, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(61, result.newNumber);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] numbers = new int[] { 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] numbers = new int[] { 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(4, result.newNumber);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(53, result.newNumber);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] numbers = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] numbers = new int[] { 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(9, result.newNumber);
        }
    }
}
