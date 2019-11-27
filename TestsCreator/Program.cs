using System;
using System.IO;
using System.Text;

namespace TestsCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startTestNumber = 131;
            int testCount = 370;

            StringBuilder sBuilder = new StringBuilder();

            Random rand = new Random(13788134);
            for (int i = 0; i < testCount; i++)
            {
                Console.WriteLine(i);
                int[] numbers = new int[rand.Next(5, 300)];
                for (int z = 0; z < numbers.Length; z++)
                {
                    numbers[z] = rand.Next(1, 20000);
                }
                Array.Sort(numbers);

                var result = Assign_5_solution.Program.Solve(numbers);

                //string test =
                //    $@"
                //[TestMethod]
                //public void TestMethod{(i + startTestNumber).ToString().PadLeft(3, '0')}()
                //{{
                //    int[] numbers = new int[] {{ {string.Join(", ", numbers)} }};

                //    var result = Program.Solve(numbers);
                //    Assert.AreEqual({result.number}, result.number);
                //    Assert.AreEqual({result.newNumber}, result.newNumber);
                //}}";
                //sBuilder.Append(test);
                //sBuilder.AppendLine();
                //sBuilder.AppendLine();

                string test =
$@"
TEST_METHOD(TestMethod{(i + startTestNumber).ToString().PadLeft(3, '0')})
{{
    int numbers[] = {{ {string.Join(", ", numbers)} }};
	span<int> spanNumbers((int*)numbers, (int)(sizeof(numbers) / sizeof(int)), true);
	auto result = Solve(spanNumbers);
	Assert::AreEqual({result.number}, result.Number);
	Assert::AreEqual({result.newNumber}, result.NewNumber);
}};";
                sBuilder.Append(test);
                sBuilder.AppendLine();
                sBuilder.AppendLine();
            }

            File.WriteAllText("tests.txt", sBuilder.ToString());
            //Console.WriteLine(sBuilder.ToString());
        }
    }
}
