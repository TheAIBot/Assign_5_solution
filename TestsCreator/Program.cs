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

            StringBuilder sBuilderCSharp = new StringBuilder();
            StringBuilder sBuilderCPP = new StringBuilder();

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

                string testCSharp =
                    $@"
                [TestMethod]
                public void TestMethod{(i + startTestNumber).ToString().PadLeft(3, '0')}()
                {{
                    int[] numbers = new int[] {{ {string.Join(", ", numbers)} }};

                    var result = Program.Solve(numbers);
                    Assert.AreEqual({result.number}, result.number);
                    Assert.AreEqual({result.newNumber}, result.newNumber);
                }}";
                sBuilderCSharp.Append(testCSharp);
                sBuilderCSharp.AppendLine();
                sBuilderCSharp.AppendLine();

                string testCPP =
$@"
TEST_METHOD(TestMethod{(i + startTestNumber).ToString().PadLeft(3, '0')})
{{
    int numbers[] = {{ {string.Join(", ", numbers)} }};
	span<int> spanNumbers((int*)numbers, (int)(sizeof(numbers) / sizeof(int)), true);
	auto result = Solve(spanNumbers);
	Assert::AreEqual({result.number}, result.Number);
	Assert::AreEqual({result.newNumber}, result.NewNumber);
}};";
                sBuilderCPP.Append(testCPP);
                sBuilderCPP.AppendLine();
                sBuilderCPP.AppendLine();
            }

            File.WriteAllText("testsCSharp.txt", sBuilderCSharp.ToString());
            File.WriteAllText("testsCPP.txt", sBuilderCPP.ToString());
            //Console.WriteLine(sBuilder.ToString());
        }
    }
}
