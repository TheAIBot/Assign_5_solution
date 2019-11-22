using System;
using System.Text;

namespace TestsCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startTestNumber = 31;
            int testCount = 100;

            StringBuilder sBuilder = new StringBuilder();

            Random rand = new Random(892372);
            for (int i = 0; i < testCount; i++)
            {
                Console.WriteLine(i);
                int[] numbers = new int[rand.Next(20, 51)];
                for (int z = 0; z < numbers.Length; z++)
                {
                    numbers[z] = rand.Next(1, 2000);
                }
                Array.Sort(numbers);

                var result = Assign_5_solution.Program.Solve(numbers);

                string test =
                    $@"
        [TestMethod]
        public void TestMethod{(i + startTestNumber).ToString().PadLeft(3, '0')}()
        {{
            int[] numbers = new int[] {{ {string.Join(", ", numbers)} }};

            var result = Program.Solve(numbers);
            Assert.AreEqual({result.number}, result.number);
            Assert.AreEqual({result.newNumber}, result.newNumber);
        }}";
                sBuilder.Append(test);
                sBuilder.AppendLine();
                sBuilder.AppendLine();
            }

            Console.WriteLine(sBuilder.ToString());
        }
    }
}
