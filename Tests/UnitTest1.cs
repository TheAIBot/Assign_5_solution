using Assign_5_solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            int[] numbers = new int[] { 7, 9, 14, 13, 42, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(61, result.newNumber);
        }

        [TestMethod]
        public void TestMethod02()
        {
            int[] numbers = new int[] { 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod03()
        {
            int[] numbers = new int[] { 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(4, result.newNumber);
        }

        [TestMethod]
        public void TestMethod04()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(53, result.newNumber);
        }

        [TestMethod]
        public void TestMethod05()
        {
            int[] numbers = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod06()
        {
            int[] numbers = new int[] { 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod07()
        {
            int[] numbers = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(20, result.newNumber);
        }

        [TestMethod]
        public void TestMethod08()
        {
            int[] numbers = new int[] { 1, 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(512, result.newNumber);
        }

        [TestMethod]
        public void TestMethod09()
        {
            int[] numbers = new int[] { 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(11, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int[] numbers = new int[] { 7, 2, 2, 6, 2, 3, 8, 6, 2, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2, result.number);
            Assert.AreEqual(43, result.newNumber);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int[] numbers = new int[] { 24, 26, 51, 33, 39, 27, 52, 4, 82, 58 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(301, result.newNumber);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int[] numbers = new int[] { 398, 153, 91, 706, 817, 540, 45, 712, 148, 907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(706, result.number);
            Assert.AreEqual(261, result.newNumber);
        }

        [TestMethod]
        public void TestMethod13()
        {
            int[] numbers = new int[] { 6, 1, 5, 10, 12, 15 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(5, result.number);
            Assert.AreEqual(35, result.newNumber);
        }

        [TestMethod]
        public void TestMethod14()
        {
            int[] numbers = new int[] { 4, 3, 1, 1, 2 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(11, result.newNumber);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int[] numbers = new int[] { 584, 822, 4, 536, 806 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod16()
        {
            int[] numbers = new int[] { 8, 4, 2, 1, 1, 8, 7, 2, 3, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(44, result.newNumber);
        }

        [TestMethod]
        public void TestMethod17()
        {
            int[] numbers = new int[] { 3, 7, 2, 1, 7, 6, 1, 5, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(40, result.newNumber);
        }


        [TestMethod]
        public void TestMethod18()
        {
            int[] numbers = new int[] { 63, 22, 2, 37, 27, 7, 72, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(8, result.number);
            Assert.AreEqual(146, result.newNumber);
        }

        [TestMethod]
        public void TestMethod19()
        {
            int[] numbers = new int[] { 465, 13, 798, 440, 514, 500, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod20()
        {
            int[] numbers = new int[] { 1658, 26, 7, 128, 1309, 70, 1828, 1858, 923, 751 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(26, result.number);
            Assert.AreEqual(8, result.newNumber);
        }
    }
}
